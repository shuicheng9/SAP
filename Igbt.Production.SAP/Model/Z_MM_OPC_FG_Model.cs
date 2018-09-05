using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP.Model
{
    public class Z_MM_OPC_FG_Model
    {
        private string _FunctionModule;
        private string _I_matnr;
        private string _I_lgort;
        private string _I_charg;
        private string _L_STOCKQUERY;
        private string _Z_MM_OPC_FG;

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
        public string Z_MM_OPC_FG
        {
            set { _Z_MM_OPC_FG = value; }
            get { return _Z_MM_OPC_FG; }

        }
        // SAP数据库表
        public string L_STOCKQUERY
        {
            set { _L_STOCKQUERY = value; }
            get { return L_STOCKQUERY; }

        }
        /// 
        /// </summary>
        public string I_matnr
        {
            set { _I_matnr = value; }
            get { return _I_matnr; }
        }
        /// <summary>
        /// 
        public string I_lgort
        {
            set { _I_lgort = value; }
            get { return _I_lgort; }
        }
        /// <summary>
        /// </summary>
        public string I_charg
        {
            set { _I_charg = value; }
            get { return _I_charg; }
        }
    }
}
