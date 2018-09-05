using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP.Model
{
    public class RFC_OUT_Message
    {
        #region 存SAP数据的返回类消息成员
        private string _E_RETURN_CODE;
        private string _E_RETURN_MESSAGE;
        private string _E_PRD_ORD_NO;
        private string _E_EXPROC;
        private string _E_PRD_CHARG;
        private string _E_PLAN_OR;
        private string _E_PO_NUMBER;
        private string _E_MAT_DOC;
        #endregion

        #region 存SAP数据返回类消息属性
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
        public string E_PRD_ORD_NO
        {
            set { _E_PRD_ORD_NO = value; }
            get { return _E_PRD_ORD_NO; }
        }
        /// <summary>
        ///  取SAP数据返回类消息属性
        /// </summary>
        public string E_EXPROC
        {
            set { _E_EXPROC = value; }
            get { return _E_EXPROC; }
        }

        public string E_MAT_DOC
        {
            set { _E_MAT_DOC = value; }
            get { return _E_MAT_DOC; }
        }
        /// <summary>
        ///  取SAP数据返回类消息属性
        /// </summary>
        public string E_PRD_CHARG
        {
            set { _E_PRD_CHARG = value; }
            get { return _E_PRD_CHARG; }
        }
        /// <summary>
        ///  取SAP数据返回类消息属性
        /// </summary>
        public string E_PLAN_OR
        {
            set { _E_PLAN_OR = value; }
            get { return _E_PLAN_OR; }
        }

        public string E_PO_NUMBER
        {
            set { _E_PO_NUMBER = value; }
            get { return _E_PO_NUMBER; }
        }
        #endregion
    }
}
