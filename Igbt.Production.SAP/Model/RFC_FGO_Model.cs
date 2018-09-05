using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP.Model
{
    public class RFC_FGO_Model
    {
        public class RFC_FGO_HEADER_Model
        {
            #region FGO表头项目
            private string _FunctionModule;
            private string _ZMESKEY;
            private string _AUFNR;
            private DateTime _BUDAT;
            private int _ZCOUNT;
            private int _ZSUM;
            private string _ZUSER;
            private string _E_SAP_FGO;

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
            public string E_SAP_FGO
            {
                set { _E_SAP_FGO = value; }
                get { return _E_SAP_FGO; }

            }
            /// <summary>
            /// MES编码
            /// </summary>
            public string ZMESKEY
            {
                set { _ZMESKEY = value; }
                get { return _ZMESKEY; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string AUFNR
            {
                set { _AUFNR = value; }
                get { return _AUFNR; }
            }
            /// <summary>
            /// 
            /// </summary>
            public DateTime BUDAT
            {
                set { _BUDAT = value; }
                get { return _BUDAT; }
            }
            /// <summary>
            ///
            /// </summary>
            public int ZCOUNT
            {
                set { _ZCOUNT = value; }
                get { return _ZCOUNT; }
            }
            /// <summary>
            /// 
            /// </summary>
            public int ZSUM
            {
                set { _ZSUM = value; }
                get { return _ZSUM; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string ZUSER
            {
                set { _ZUSER = value; }
                get { return _ZUSER; }
            }
            #endregion
        }

        public class RFC_FGO_ITEM_Model
        {
            #region FGO行项目
            private string _ZMESITEM;
            private string _BWART;
            private string _WERKS;
            private string _LGORT;
            private int _MENGE;
            private string _MEINS;
            private string _ZINBOXNO_MIN;
            private string _ZINBOXNO_MAX;
            private string _ZLOTNO;
            private string _ZINBOXNO;

            /// <summary>
            /// MES行号
            /// </summary>
            public string ZMESITEM
            {
                set { _ZMESITEM = value; }
                get { return _ZMESITEM; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string BWART
            {
                set { _BWART = value; }
                get { return _BWART; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string WERKS
            {
                set { _WERKS = value; }
                get { return _WERKS; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string LGORT
            {
                set { _LGORT = value; }
                get { return _LGORT; }
            }
            /// <summary>
            /// 
            /// </summary>
            public int MENGE
            {
                set { _MENGE = value; }
                get { return _MENGE; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string MEINS
            {
                set { _MEINS = value; }
                get { return _MEINS; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string ZINBOXNO_MIN
            {
                set { _ZINBOXNO_MIN = value; }
                get { return _ZINBOXNO_MIN; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string ZINBOXNO_MAX
            {
                set { _ZINBOXNO_MAX = value; }
                get { return _ZINBOXNO_MAX; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string ZLOTNO
            {
                set { _ZLOTNO = value; }
                get { return _ZLOTNO; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string ZINBOXNO
            {
                set { _ZINBOXNO = value; }
                get { return _ZINBOXNO; }
            }
            #endregion
        }
    }
}
