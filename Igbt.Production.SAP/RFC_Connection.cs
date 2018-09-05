using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP
{
    /// <summary>
    /// 连接SAP
    /// </summary>
     public class RFC_Connection
    {
        IDestinationConfiguration ID;
        public RfcDestination dest;
        public RfcRepository repository;
        /// <summary>
        /// 测试连接SAP
        /// </summary>
        /// <returns></returns>
        public bool ConnSap(out string message)
        {
            bool result = false;
            try
            {
                IDestinationConfiguration ID = new RFC_SetUp();
                RfcDestinationManager.RegisterDestinationConfiguration(ID);
                RfcDestination destination = RfcDestinationManager.GetDestination("SAPMS");
                RfcRepository repository = destination.Repository;
                IRfcFunction rfcFunction = repository.CreateFunction("Z_TEST_CONNECTION");
                rfcFunction.Invoke(destination);
                message = rfcFunction.GetValue("E_RETURN_MESSAGE").ToString();
                result = !(rfcFunction.GetValue("E_RETURN_CODE").ToString() == "E");
               
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                RfcDestinationManager.UnregisterDestinationConfiguration(ID);
            }
            return result;
        }
    }
}
