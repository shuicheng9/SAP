using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP
{
    public class RFC_Parameters_Model
    {
        private string _RFC_AppServerHost;
        private string _RFC_SystemNumber;
        private string _RFC_User;
        private string _RFC_Password;
        private string _RFC_Client;
        private string _RFC_Language;
        private string _RFC_PoolSize;
        private string _RFC_IdleTimeout;
        private string _RFC_MaxPoolSize;

        /// <summary>
        /// SAP登录参数配置
        /// </summary>
        public string RFC_AppServerHost
        {
            set { _RFC_AppServerHost = value; }
            get { return _RFC_AppServerHost; } 
        }

        public string RFC_SystemNumber
        {
            set { _RFC_SystemNumber = value; }
            get { return _RFC_SystemNumber; } 
        }

        public string RFC_User
        {
            set { _RFC_User = value; }
            get { return _RFC_User; } 
        }

        public string RFC_Password
        {
            set { _RFC_Password = value; }
            get { return _RFC_Password; } 
        }

        public string RFC_Client
        {
            set { _RFC_Client = value; }
            get { return _RFC_Client; } 
        }

        public string RFC_Language
        {
            set { _RFC_Language = value; }
            get { return _RFC_Language; } 
        }

        public string RFC_PoolSize
        {
            set { _RFC_PoolSize = value; }
            get { return _RFC_PoolSize; } 
        }

        public string RFC_MaxPoolSize
        {
            set { _RFC_MaxPoolSize = value; }
            get { return _RFC_MaxPoolSize; } 
        }

        public string RFC_IdleTimeout
        {
            set { _RFC_IdleTimeout = value; }
            get { return _RFC_IdleTimeout; } 
        }
    }
}
