using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP.Model
{
    public class RFC_IN_Message
    {
        #region 取SAP数据的返回类消息成员
        private string _E_RETURN_CODE;
        private string _E_RETURN_MESSAGE;
        private string _E_COUNT;
        private string _E_SUM;
        private string _E_SUBRC;
        private string _E_MESSAGE;
        #endregion

        #region 取SAP数据返回类消息属性
        /// <summary>
        ///  取SAP数据返回类消息属性
        /// </summary>
        public string E_RETURN_CODE
        {
            set { _E_RETURN_CODE = value; }
            get { return _E_RETURN_CODE; } 
        }
        /// <summary>
        ///  取SAP数据返回类消息属性
        /// </summary>
        public string E_RETURN_MESSAGE
        {
            set { _E_RETURN_MESSAGE = value; }
            get { return _E_RETURN_MESSAGE; }
        }
        /// <summary>
        ///  取SAP数据返回类消息属性
        /// </summary>
        public string E_COUNT
        {
            set { _E_COUNT = value; }
            get { return _E_COUNT; }
        }
        /// <summary>
        ///  取SAP数据返回类消息属性
        /// </summary>
        public string E_SUM
        {
            set { _E_SUM = value; }
            get { return _E_SUM; }
        }
        /// <summary>
        ///  取SAP数据返回类消息属性
        /// </summary>
        public string E_SUBRC
        {
            set { _E_SUBRC = value; }
            get { return _E_SUBRC; }
        }
        /// <summary>
        ///  取SAP数据返回类消息属性
        /// </summary>
        public string E_MESSAGE
        {
            set { _E_MESSAGE = value; }
            get { return _E_MESSAGE; }
        }
        #endregion

    }
}
