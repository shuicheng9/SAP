using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.Model;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP.DAL
{
    public class RFC_RMU_LY_DAL
    {
        private IDestinationConfiguration _configurationId;
        private RfcDestination _dest;
        private RfcRepository _repository;

        public RFC_OUT_Message Rfc_Rmu_Ly_Dal(List<RFC_RMU_LY_Model.RFC_RMU_LY_ITEM_Model> rmuLyItemModels, RFC_RMU_LY_Model.RFC_RMU_LY_HEADER_Model rmuLyHeaderModel)
        {
            RFC_OUT_Message rfcMessage = new RFC_OUT_Message();
            try
            {
                _configurationId = new RFC_SetUp();
                RfcDestinationManager.RegisterDestinationConfiguration(_configurationId);
                _dest = RfcDestinationManager.GetDestination("SAPMS");
                _repository = _dest.Repository;
                IRfcFunction rfc = _repository.CreateFunction(rmuLyHeaderModel.FunctionModule);   //调用函数名                
                IRfcTable table = rfc.GetTable("T_DATA");                            //RFC表数据
                IRfcStructure structure = rfc.GetStructure("I_HEADER");             //RFC表头数据
                structure.SetValue("ZMESKEY", rmuLyHeaderModel.ZMESKEY);
                structure.SetValue("BLDAT", rmuLyHeaderModel.BLDAT);
                structure.SetValue("BUDAT", rmuLyHeaderModel.BUDAT);
                structure.SetValue("ZCOUNT", rmuLyHeaderModel.ZCOUNT);
                structure.SetValue("ZSUM", rmuLyHeaderModel.ZSUM);
                structure.SetValue("ZUSER", rmuLyHeaderModel.ZUSER);
                structure.SetValue("ZUNPLAN", rmuLyHeaderModel.ZUNPLAN);

                foreach (var _rmuLyItemModels in rmuLyItemModels)
                {
                    table.Insert();
                    table.CurrentRow.SetValue("ZMESITEM", _rmuLyItemModels.ZMESITEM);
                    table.CurrentRow.SetValue("RSNUM", _rmuLyItemModels.RSNUM);
                    table.CurrentRow.SetValue("RSPOS", _rmuLyItemModels.RSPOS);
                    table.CurrentRow.SetValue("BWART", _rmuLyItemModels.BWART);
                    table.CurrentRow.SetValue("MATNR", _rmuLyItemModels.MATNR);
                    table.CurrentRow.SetValue("WERKS", _rmuLyItemModels.WERKS);
                    table.CurrentRow.SetValue("LGORT", _rmuLyItemModels.LGORT);
                    table.CurrentRow.SetValue("MENGE", _rmuLyItemModels.MENGE);
                    table.CurrentRow.SetValue("MEINS", _rmuLyItemModels.MEINS);
                    table.CurrentRow.SetValue("CHARG", _rmuLyItemModels.CHARG);
                    table.CurrentRow.SetValue("ITEM_TEXT", _rmuLyItemModels.ITEM_TEXT);
                    //rmuLyHeaderModel.ZSUM += _rmuLyItemModels.MENGE;//所有数据全部相加，取总数
                }
                structure.SetValue("ZSUM", rmuLyHeaderModel.ZSUM);
                rfc.Invoke(_dest);
                rfcMessage.E_RETURN_CODE = rfc.GetString("E_RETURN_CODE").ToString();
                rfcMessage.E_RETURN_MESSAGE = rfc.GetString("E_RETURN_MESSAGE").ToString();
                //rfcMessage.E_PO_NUMBER = rfc.GetInt("E_COUNT").ToString();
                rfcMessage.E_EXPROC = rfc.GetString("E_MAT_DOC").ToString();
                return rfcMessage;
            }
            catch (Exception exception)
            {
                rfcMessage.E_RETURN_MESSAGE = "接口RMU_LY 错误：" + exception.ToString();
                return null;
            }
            finally
            {
                RfcDestinationManager.UnregisterDestinationConfiguration(_configurationId);
            }
        }
    }
}
