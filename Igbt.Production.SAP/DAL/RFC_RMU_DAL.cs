using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.Model;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP.DAL
{
    public class RFC_RMU_DAL
    {
        private IDestinationConfiguration _configurationId;
        private RfcDestination _dest;
        private RfcRepository _repository;

        public RFC_OUT_Message Rfc_Rmu_Dal(List<RFC_RMU_Model.RFC_RMU_ITEM_Model> rmuItemModel, RFC_RMU_Model.RFC_RMU_HEADER_Model rmuHeaderModel)
        {
            RFC_OUT_Message rfcMessage = new RFC_OUT_Message();
            try
            {
                _configurationId = new RFC_SetUp();
                RfcDestinationManager.RegisterDestinationConfiguration(_configurationId);
                _dest = RfcDestinationManager.GetDestination("SAPMS");
                _repository = _dest.Repository;
                IRfcFunction rfc = _repository.CreateFunction("Z_PP_MES_OUT_RMU");   //调用函数名                
                IRfcTable table = rfc.GetTable(rmuHeaderModel.E_SAP_RMU);                            //RFC表数据
                IRfcStructure structure = rfc.GetStructure("I_HEADER");             //RFC表头数据
                structure.SetValue("ZMESKEY", rmuHeaderModel.ZMESKEY);
                structure.SetValue("BLDAT", rmuHeaderModel.BLDAT);
                structure.SetValue("BUDAT", rmuHeaderModel.BUDAT);
                structure.SetValue("ZCOUNT", rmuHeaderModel.ZCOUNT);              
                structure.SetValue("ZUSER", rmuHeaderModel.ZUSER);
                structure.SetValue("ZUNPLAN", rmuHeaderModel.ZUNPLAN);
                try
                {
                    structure.SetValue("BKTXT", rmuHeaderModel.BKTXT);
                }
                catch  {}

                foreach (var _rmuItemModel in rmuItemModel)
                {
                    table.Insert();
                    table.CurrentRow.SetValue("ZMESITEM", _rmuItemModel.ZMESITEM);
                    table.CurrentRow.SetValue("AUFNR", _rmuItemModel.AUFNR);
                    table.CurrentRow.SetValue("POSNR", _rmuItemModel.POSNR);
                    table.CurrentRow.SetValue("BWART", _rmuItemModel.BWART);
                    table.CurrentRow.SetValue("MATNR", _rmuItemModel.MATNR);
                    table.CurrentRow.SetValue("WERKS", _rmuItemModel.WERKS);
                    table.CurrentRow.SetValue("LGORT", _rmuItemModel.LGORT);
                    table.CurrentRow.SetValue("MENGE", _rmuItemModel.MENGE);
                    table.CurrentRow.SetValue("MEINS", _rmuItemModel.MEINS);
                    table.CurrentRow.SetValue("CHARG", _rmuItemModel.CHARG);
                    table.CurrentRow.SetValue("ITEM_TEXT", _rmuItemModel.ITEM_TEXT);

                   // rmuHeaderModel.ZSUM += _rmuItemModel.MENGE;//所有数据全部相加，取总数
                }
                structure.SetValue("ZSUM", rmuHeaderModel.ZSUM);
                rfc.Invoke(_dest);
                rfcMessage.E_RETURN_CODE = rfc.GetString("E_RETURN_CODE").ToString();
                rfcMessage.E_RETURN_MESSAGE = rfc.GetString("E_RETURN_MESSAGE").ToString();
                rfcMessage.E_EXPROC = rfc.GetString("E_MAT_DOC").ToString();
                return rfcMessage;
            }
            catch (Exception exception)
            {
                rfcMessage.E_RETURN_MESSAGE = "接口RMU 错误：" + exception.ToString();
                return null;
            }
            finally
            {
                RfcDestinationManager.UnregisterDestinationConfiguration(_configurationId);
            }
        }
    }
}
