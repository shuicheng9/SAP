using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.Model;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP.DAL
{
    public class RFC_FGU_DAL
    {
        private IDestinationConfiguration _configurationId;
        private RfcDestination _dest;
        private RfcRepository _repository;

        public RFC_OUT_Message Rfc_Fgu_Dal(List<RFC_FGU_Model.RFC_FGU_ITEM_Model> fguItemModel, RFC_FGU_Model.RFC_FGU_HEADER_Model fguHeaderModel)
        {
            RFC_OUT_Message rfcMessage = new RFC_OUT_Message();
            try
            {
                _configurationId = new RFC_SetUp();
                RfcDestinationManager.RegisterDestinationConfiguration(_configurationId);
                _dest = RfcDestinationManager.GetDestination("SAPMS");
                _repository = _dest.Repository;
                IRfcFunction rfc = _repository.CreateFunction(fguHeaderModel.FunctionModule);   //调用函数名                
                IRfcTable table = rfc.GetTable(fguHeaderModel.E_SAP_FGU);                            //RFC表数据
                IRfcStructure structure = rfc.GetStructure("I_HEADER");             //RFC表头数据
                structure.SetValue("ZMESKEY", fguHeaderModel.ZMESKEY);
                structure.SetValue("VBELN", fguHeaderModel.VBELN);
                structure.SetValue("WADAT_IST", fguHeaderModel.WADAT_IST);
                structure.SetValue("ZCOUNT", fguHeaderModel.ZCOUNT);
                structure.SetValue("ZSUM", fguHeaderModel.ZSUM);
                structure.SetValue("ZUSER", fguHeaderModel.ZUSER);
                structure.SetValue("ZSTEP", fguHeaderModel.ZSTEP);

                foreach (var _fguItemModel in fguItemModel)
                {
                    table.Insert();
                    table.CurrentRow.SetValue("ZMESITEM", _fguItemModel.ZMESITEM);
                    table.CurrentRow.SetValue("POSNR", _fguItemModel.POSNR);
                    table.CurrentRow.SetValue("MATNR", _fguItemModel.MATNR);
                    table.CurrentRow.SetValue("MENGE", _fguItemModel.MENGE);
                    table.CurrentRow.SetValue("MEINS", _fguItemModel.MEINS);
                    table.CurrentRow.SetValue("CHARG", _fguItemModel.CHARG);
                    table.CurrentRow.SetValue("ZLOTNO", _fguItemModel.ZLOTNO);
                    table.CurrentRow.SetValue("ZINBOXNO", _fguItemModel.ZINBOXNO);
                    table.CurrentRow.SetValue("LOTQTY", _fguItemModel.LOTQTY);
                    //fguHeaderModel.ZSUM += _fguItemModel.MENGE;//所有数据全部相加，取总数
                }
                structure.SetValue("ZSUM", fguHeaderModel.ZSUM);
                rfc.Invoke(_dest);
                rfcMessage.E_RETURN_CODE = rfc.GetString("E_RETURN_CODE").ToString();
                rfcMessage.E_RETURN_MESSAGE = rfc.GetString("E_RETURN_MESSAGE").ToString();
                rfcMessage.E_MAT_DOC = rfc.GetString("E_MAT_DOC").ToString();
                //rfcMessage.E_PO_NUMBER = rfc.GetInt("E_COUNT").ToString();
                //rfcMessage.E_EXPROC = rfc.GetInt("E_SUM").ToString();
                return rfcMessage;
            }
            catch (Exception exception)
            {
                rfcMessage.E_RETURN_MESSAGE = "接口FGU 错误：" + exception.ToString();
                return null;
            }
            finally
            {
                RfcDestinationManager.UnregisterDestinationConfiguration(_configurationId);
            }
        }
    }
}
