using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.Model;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP.DAL
{
    public class RFC_GRP_DAL
    {
        private IDestinationConfiguration _configurationId;
        private RfcDestination _dest;
        private RfcRepository _repository;

        public RFC_OUT_Message Rfc_Gpr_Dal(List<RFC_GPR_Model.RFC_GPR_ITEM_Model> gprItemModel,RFC_GPR_Model.RFC_GPR_HEADER_Model gprHeaderModel)
        {
            RFC_OUT_Message rfcMessage = new RFC_OUT_Message();
            try
            {
                _configurationId = new RFC_SetUp();
                RfcDestinationManager.RegisterDestinationConfiguration(_configurationId);
                _dest = RfcDestinationManager.GetDestination("SAPMS");
                _repository = _dest.Repository;
                IRfcFunction rfc = _repository.CreateFunction(gprHeaderModel.FunctionModule);   //调用函数名                
                IRfcTable table = rfc.GetTable(gprHeaderModel.E_SAP_GRP);                            //RFC表数据
                IRfcStructure structure = rfc.GetStructure("I_HEADER");             //RFC表头数据
                structure.SetValue("ZMESKEY", gprHeaderModel.ZMESKEY);
                structure.SetValue("EBELN", gprHeaderModel.EBELN);
                structure.SetValue("BUKRS", gprHeaderModel.BUKRS);
                structure.SetValue("BSART", gprHeaderModel.BSART);
                structure.SetValue("EKORG", gprHeaderModel.EKORG);
                structure.SetValue("AEDAT", gprHeaderModel.AEDAT);
                structure.SetValue("LIFNR", gprHeaderModel.LIFNR);
                structure.SetValue("ZCOUNT", gprHeaderModel.ZCOUNT);
                structure.SetValue("ZUSER", gprHeaderModel.ZUSER);
                foreach (var _gprItemModel in gprItemModel)
                {
                    table.Insert();
                    table.CurrentRow.SetValue("ZMESITEM", _gprItemModel.ZMESITEM);
                    table.CurrentRow.SetValue("EBELP", _gprItemModel.EBELP);
                    table.CurrentRow.SetValue("LOEKZ", _gprItemModel.LOEKZ);
                    table.CurrentRow.SetValue("MATNR", _gprItemModel.MATNR);
                    table.CurrentRow.SetValue("WERKS", _gprItemModel.WERKS);
                    table.CurrentRow.SetValue("LGORT", _gprItemModel.LGORT);
                    table.CurrentRow.SetValue("MENGE", _gprItemModel.MENGE);
                    table.CurrentRow.SetValue("MEINS", _gprItemModel.MEINS);
                    table.CurrentRow.SetValue("EINDT", _gprItemModel.EINDT);
                    table.CurrentRow.SetValue("LICHA", _gprItemModel.LICHA);
                    table.CurrentRow.SetValue("ZJPSONO", _gprItemModel.ZJPSONO);
                    table.CurrentRow.SetValue("ZJPSOITEM", _gprItemModel.ZJPSOITEM);
                    gprHeaderModel.ZSUM += _gprItemModel.MENGE;//所有数据全部相加，取总数
                }
                structure.SetValue("ZSUM", gprHeaderModel.ZSUM);
                rfc.Invoke(_dest);
                rfcMessage.E_RETURN_CODE = rfc.GetString("E_RETURN_CODE").ToString();
                //rfcMessage.E_RETURN_MESSAGE = rfc.GetString("E_RETURN_MESSAGE").ToString();
                rfcMessage.E_PO_NUMBER = rfc.GetInt("E_COUNT").ToString();
                rfcMessage.E_EXPROC = rfc.GetInt("E_SUM").ToString();
                return rfcMessage;
            }
            catch (Exception exception)
            {
                rfcMessage.E_RETURN_MESSAGE = "接口GPR 错误：" + exception.ToString();
                return null;
            }
            finally
            {
                RfcDestinationManager.UnregisterDestinationConfiguration(_configurationId);
            }
        }
    }
}
