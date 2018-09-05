using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.Model;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP.DAL
{
    public class Z_MM_OPC_FG
    {
        private IDestinationConfiguration _configurationId;
        private RfcDestination _dest;
        private RfcRepository _repository;

        public IRfcTable Rfc_Goods_Dal(string I_FLAG, string I_RSNUM, string TABLES , out RFC_IN_Message rfcMessage)
        {
            rfcMessage = new RFC_IN_Message();
            try
            {
                _configurationId = new RFC_SetUp();
                RfcDestinationManager.RegisterDestinationConfiguration(_configurationId);
                _dest = RfcDestinationManager.GetDestination("SAPMS");
                _repository = _dest.Repository;
                IRfcFunction rfc = _repository.CreateFunction("Z_MM_OPC_FG");   //调用函数名       
                
                if (I_FLAG == "E")
                {
                    IRfcTable table = rfc.GetTable(TABLES);
                    rfc.SetValue("I_FLAG", "E");
                    rfc.Invoke(_dest);
                    return table;
                }
                else
                {
                    IRfcTable table = rfc.GetTable(TABLES);
                    rfc.SetValue("I_RSNUM", I_RSNUM);
                    rfc.SetValue("I_FLAG", "B");
                    rfc.Invoke(_dest);
                    return table;
                }
            }
            catch (Exception exception)
            {
                rfcMessage.E_RETURN_MESSAGE = "接口库存 错误：" + exception.ToString();
                return null;
            }
            finally
            {
                RfcDestinationManager.UnregisterDestinationConfiguration(_configurationId);
            }
        }
    }
}
