using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.Model;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP.DAL
{
    public class RFC_GRW_DAL
    {
        private IDestinationConfiguration _configurationId;
        private RfcDestination _dest;
        private RfcRepository _repository;

        public RFC_OUT_Message Rfc_Grw_Dal(List<RFC_GRW_Model.RFC_GRW_ITEM_Model> grwItemModel, RFC_GRW_Model.RFC_GRW_HEADER_Model grwHeaderModel)
        {
            RFC_OUT_Message rfcMessage = new RFC_OUT_Message();
            try
            {
                _configurationId = new RFC_SetUp();
                RfcDestinationManager.RegisterDestinationConfiguration(_configurationId);
                _dest = RfcDestinationManager.GetDestination("SAPMS");
                _repository = _dest.Repository;
                IRfcFunction rfc = _repository.CreateFunction(grwHeaderModel.FunctionModule);   //调用函数名                
                IRfcTable table = rfc.GetTable(grwHeaderModel.E_SAP_GRW);                            //RFC表数据
                IRfcStructure structure = rfc.GetStructure("I_HEADER");             //RFC表头数据
                structure.SetValue("ZMESKEY", grwHeaderModel.ZMESKEY);
                structure.SetValue("BUDAT", grwHeaderModel.BUDAT);
                structure.SetValue("XBLNR", grwHeaderModel.XBLNR);
                structure.SetValue("ZCOUNT", grwHeaderModel.ZCOUNT);
                //structure.SetValue("ZSUM", 0);
                structure.SetValue("ZUSER", grwHeaderModel.ZUSER);
                structure.SetValue("BKTXT", grwHeaderModel.BKTXT);
                table.Clear();
                foreach (var _grwItemModel in grwItemModel)
                {
                    table.Insert();
                    table.CurrentRow.SetValue("ZMESITEM", _grwItemModel.ZMESITEM);
                    table.CurrentRow.SetValue("EBELN", _grwItemModel.EBELN);
                    table.CurrentRow.SetValue("EBELP", _grwItemModel.EBELP);
                    table.CurrentRow.SetValue("BWART", _grwItemModel.BWART);
                    table.CurrentRow.SetValue("MATNR", _grwItemModel.MATNR);
                    table.CurrentRow.SetValue("WERKS", _grwItemModel.WERKS);
                    table.CurrentRow.SetValue("LGORT", _grwItemModel.LGORT);
                    table.CurrentRow.SetValue("MENGE", _grwItemModel.MENGE);
                    table.CurrentRow.SetValue("MEINS", _grwItemModel.MEINS);
                    table.CurrentRow.SetValue("LICHA", _grwItemModel.LICHA);
                    table.CurrentRow.SetValue("CHARG", _grwItemModel.CHARG);
                    //grwHeaderModel.ZSUM += _grwItemModel.MENGE;//所有数据全部相加，取总数
                }
                structure.SetValue("ZSUM", grwHeaderModel.ZSUM);
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
                rfcMessage.E_RETURN_MESSAGE = "接口GPW 错误：" + exception.ToString();
                return null;
            }
            finally
            {
                RfcDestinationManager.UnregisterDestinationConfiguration(_configurationId);
            }
        }
    }
}
