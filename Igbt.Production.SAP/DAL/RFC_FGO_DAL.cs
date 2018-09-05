using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.Model;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP.DAL
{
    public  class RFC_FGO_DAL
    {
        private IDestinationConfiguration _configurationId;
        private RfcDestination _dest;
        private RfcRepository _repository;

        public RFC_OUT_Message  Rfc_Fgo_Dal(List<RFC_FGO_Model.RFC_FGO_ITEM_Model> fgoItemModel, RFC_FGO_Model.RFC_FGO_HEADER_Model fgoHeaderModel)
        {
            RFC_OUT_Message rfcMessage = new RFC_OUT_Message();
            try
            {
                _configurationId = new RFC_SetUp();
                RfcDestinationManager.RegisterDestinationConfiguration(_configurationId);
                _dest = RfcDestinationManager.GetDestination("SAPMS");
                _repository = _dest.Repository;
                IRfcFunction rfc = _repository.CreateFunction("Z_PP_MES_OUT_FGO");   //调用函数名                
                IRfcTable table = rfc.GetTable("T_DATA");                            //RFC表数据
                IRfcStructure structure = rfc.GetStructure("I_HEADER");             //RFC表头数据
                structure.SetValue("ZMESKEY", fgoHeaderModel.ZMESKEY);
                structure.SetValue("AUFNR", fgoHeaderModel.AUFNR);
                structure.SetValue("BUDAT", fgoHeaderModel.BUDAT);
                structure.SetValue("ZCOUNT", fgoHeaderModel.ZCOUNT);
                //structure.SetValue("ZSUM", fgoHeaderModel.ZSUM);
                structure.SetValue("ZUSER", fgoHeaderModel.ZUSER);

                fgoHeaderModel.ZSUM = 0;

                foreach (var _fgoItemModel in fgoItemModel)
                {
                    table.Insert();
                    table.CurrentRow.SetValue("ZMESITEM", _fgoItemModel.ZMESITEM);
                    table.CurrentRow.SetValue("BWART", _fgoItemModel.BWART);
                    table.CurrentRow.SetValue("WERKS", _fgoItemModel.WERKS);
                    table.CurrentRow.SetValue("LGORT", _fgoItemModel.LGORT);
                    table.CurrentRow.SetValue("MENGE", _fgoItemModel.MENGE);
                    table.CurrentRow.SetValue("MEINS", _fgoItemModel.MEINS);
                    table.CurrentRow.SetValue("ZINBOXNO_MIN", _fgoItemModel.ZINBOXNO_MIN);
                    table.CurrentRow.SetValue("ZINBOXNO_MAX", _fgoItemModel.ZINBOXNO_MIN);
                    table.CurrentRow.SetValue("ZLOTNO", _fgoItemModel.ZLOTNO);
                    table.CurrentRow.SetValue("ZINBOXNO", _fgoItemModel.ZINBOXNO);
                    fgoHeaderModel.ZSUM += _fgoItemModel.MENGE;//所有数据全部相加，取总数
                }
                structure.SetValue("ZSUM", fgoHeaderModel.ZSUM);
                rfc.Invoke(_dest);
                rfcMessage.E_RETURN_CODE = rfc.GetString("E_RETURN_CODE").ToString();
                rfcMessage.E_RETURN_MESSAGE = rfc.GetString("E_RETURN_MESSAGE").ToString();
                //rfcMessage.E_PO_NUMBER = rfc.GetInt("E_COUNT").ToString();
                //rfcMessage.E_EXPROC = rfc.GetInt("E_SUM").ToString();
                rfcMessage.E_MAT_DOC = rfc.GetString("E_MAT_DOC").ToString();
                rfcMessage.E_EXPROC = rfc.GetString("E_EXPROC").ToString();
                return rfcMessage;
            }
            catch (Exception exception)
            {
                rfcMessage.E_RETURN_MESSAGE = "接口FGO 错误：" + exception.ToString();
                return null;
            }
            finally
            {
                RfcDestinationManager.UnregisterDestinationConfiguration(_configurationId);
            }
        }
    }
}
