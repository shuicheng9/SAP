using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP
{
    public class RFC_SSO_Model
    {
        private string _FunctionModule;
        private string _I_MESKEY;
        private DateTime _I_DATE;
        private DateTime _I_TIME;
        private string _I_USER;
        private string _I_VBELN;
        private string _E_SAP_SSO;

        /// <summary>
        /// SAP函数接口名称
        /// </summary>
        public string FunctionModule
        {
            set { _FunctionModule = value; }
            get { return _FunctionModule; } 
        }
        /// <summary>
        /// SAP数据库表
        /// </summary>
        public string E_SAP_SSO
        {
            set { _E_SAP_SSO = value; }
            get { return _E_SAP_SSO; }
        }

        /// <summary>
        /// MES编码
        /// </summary>
        public string I_MESKEY
        {
            set { _I_MESKEY = value; }
            get { return _I_MESKEY; } 
        }

        /// <summary>
        /// 日期
        /// </summary>
        public DateTime I_DATE
        {
            set { _I_DATE = value; }
            get { return _I_DATE; } 
        }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime I_TIME
        {
            set { _I_TIME = value; }
            get { return _I_TIME; } 
        }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string I_USER
        {
            set { _I_USER = value; }
            get { return _I_USER; } 
        }
        /// <summary>
        /// 销售订单号
        /// </summary>
        public string I_VBELN
        {
            set { _I_VBELN = value; }
            get { return _I_VBELN; }
        }
    }
}
