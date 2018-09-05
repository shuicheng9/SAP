using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.Model;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP.DAL
{
    public class RFC_STU_DAL
    {
        private IDestinationConfiguration _configurationId;
        private RfcDestination _dest;
        private RfcRepository _repository;

        public RFC_OUT_Message Rfc_Stu_Dal(List<RFC_STU_Model.RFC_STU_ITEM_Model> stuItemModel, RFC_STU_Model.RFC_STU_HEADER_Model stuHeaderModel)
        {
            RFC_OUT_Message rfcMessage = new RFC_OUT_Message();
            try
            {
                _configurationId = new RFC_SetUp();
                RfcDestinationManager.RegisterDestinationConfiguration(_configurationId);
                _dest = RfcDestinationManager.GetDestination("SAPMS");
                _repository = _dest.Repository;
                IRfcFunction rfc = _repository.CreateFunction(stuHeaderModel.FunctionModule);   //调用函数名                
                IRfcTable table = rfc.GetTable("T_DATA");                            //RFC表数据
                IRfcStructure structure = rfc.GetStructure("I_HEADER");             //RFC表头数据
                structure.SetValue("ZMESKEY", stuHeaderModel.ZMESKEY);
                structure.SetValue("BUDAT", stuHeaderModel.BUDAT);
                structure.SetValue("ZCOUNT", stuHeaderModel.ZCOUNT);
                structure.SetValue("ZSUM", stuHeaderModel.ZSUM);
                structure.SetValue("ZUSER", stuHeaderModel.ZUSER);
                structure.SetValue("BKTXT", stuHeaderModel.BKTXT);

                table.Clear();
                foreach (var _stuItemModel in stuItemModel)
                {
                    table.Insert();
                    table.CurrentRow.SetValue("ZMESITEM", _stuItemModel.ZMESITEM);
                    table.CurrentRow.SetValue("BWART", _stuItemModel.BWART);
                    table.CurrentRow.SetValue("MATNR", _stuItemModel.MATNR);
                    table.CurrentRow.SetValue("WERKS", _stuItemModel.WERKS);
                    table.CurrentRow.SetValue("LGORT", _stuItemModel.LGORT);
                    table.CurrentRow.SetValue("MENGE", _stuItemModel.MENGE);
                    table.CurrentRow.SetValue("MEINS", _stuItemModel.MEINS);
                    table.CurrentRow.SetValue("CHARG", _stuItemModel.CHARG);
                    table.CurrentRow.SetValue("ZEILE", _stuItemModel.ZEILE);
                    table.CurrentRow.SetValue("UMLGO", _stuItemModel.UMLGO);
                    table.CurrentRow.SetValue("LIFNR", _stuItemModel.LIFNR);
                    table.CurrentRow.SetValue("SOBKZ", _stuItemModel.SOBKZ);
                    //stuHeaderModel.ZSUM += _stuItemModel.MENGE;//所有数据全部相加，取总数
                }
                structure.SetValue("ZSUM", stuHeaderModel.ZSUM);
                rfc.Invoke(_dest);
                rfcMessage.E_RETURN_CODE = rfc.GetString("E_RETURN_CODE").ToString();
                rfcMessage.E_RETURN_MESSAGE = rfc.GetString("E_RETURN_MESSAGE").ToString();
                //rfcMessage.E_PO_NUMBER = rfc.GetInt("E_COUNT").ToString();
                //rfcMessage.E_EXPROC = rfc.GetInt("E_SUM").ToString();
                rfcMessage.E_MAT_DOC = rfc.GetString("E_MAT_DOC").ToString();
                return rfcMessage;
            }
            catch (Exception exception)
            {
                rfcMessage.E_RETURN_MESSAGE = "接口STU 错误：" + exception.ToString();
                return null;
            }
            finally
            {
                RfcDestinationManager.UnregisterDestinationConfiguration(_configurationId);
            }
        }
    }
}
