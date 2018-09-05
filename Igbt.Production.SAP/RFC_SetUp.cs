using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP
{
    /// <summary>
    /// RFC的连接配置
    /// </summary>
    public class RFC_SetUp : IDestinationConfiguration
    {
        RFC_Parameters_Model rfc_Parameters = new RFC_Parameters_Model();
        public RfcConfigParameters GetParameters(string destinationName)
        {
            if (destinationName.Equals("SAPMS"))
            {
                RfcConfigParameters rfcParams = new RfcConfigParameters();
                rfc_Parameters = Configuration_RFC();//获取连接参数
                rfcParams.Add(RfcConfigParameters.AppServerHost, rfc_Parameters.RFC_AppServerHost);
                rfcParams.Add(RfcConfigParameters.SystemNumber, rfc_Parameters.RFC_SystemNumber);
                rfcParams.Add(RfcConfigParameters.User, rfc_Parameters.RFC_User);
                rfcParams.Add(RfcConfigParameters.Password, rfc_Parameters.RFC_Password);
                rfcParams.Add(RfcConfigParameters.Client, rfc_Parameters.RFC_Client);
                rfcParams.Add(RfcConfigParameters.Language, rfc_Parameters.RFC_Language);
                rfcParams.Add(RfcConfigParameters.PoolSize, rfc_Parameters.RFC_PoolSize);
                rfcParams.Add(RfcConfigParameters.MaxPoolSize, rfc_Parameters.RFC_MaxPoolSize);
                rfcParams.Add(RfcConfigParameters.IdleTimeout, rfc_Parameters.RFC_IdleTimeout);
                return rfcParams;
            }
            else
            {
                return null;
            }
        }
        public bool ChangeEventsSupported()
        {
            return false;
        }
        public event RfcDestinationManager.ConfigurationChangeHandler ConfigurationChanged;

        private RFC_Parameters_Model Configuration_RFC()
        {
            rfc_Parameters.RFC_AppServerHost = ConfigurationManager.AppSettings["RFC_AppServerHost"];
            rfc_Parameters.RFC_SystemNumber = ConfigurationManager.AppSettings["RFC_SystemNumber"];
            rfc_Parameters.RFC_User = ConfigurationManager.AppSettings["RFC_User"];
            rfc_Parameters.RFC_Password = ConfigurationManager.AppSettings["RFC_Password"];
            rfc_Parameters.RFC_Client = ConfigurationManager.AppSettings["RFC_Client"];
            rfc_Parameters.RFC_Language = ConfigurationManager.AppSettings["RFC_Language"];
            rfc_Parameters.RFC_PoolSize = ConfigurationManager.AppSettings["RFC_PoolSize"];
            rfc_Parameters.RFC_MaxPoolSize = ConfigurationManager.AppSettings["RFC_MaxPoolSize"];
            rfc_Parameters.RFC_IdleTimeout = ConfigurationManager.AppSettings["RFC_IdleTimeout"];
            return rfc_Parameters;
        }
    }
}
