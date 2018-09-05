using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP.Model
{
    public class RFC_RMU_LY_Model
    {
        public class RFC_RMU_LY_HEADER_Model
        {
            private string _FunctionModule;
            private string _ZMESKEY;
            private DateTime _BLDAT;
            private DateTime _BUDAT;
            private int _ZCOUNT;
            private int _ZSUM;
            private string _ZUSER;
            private string _ZUNPLAN;

            /// <summary>
            /// 
            /// </summary>
            public string FunctionModule
            {
                set { _FunctionModule = value; }
                get { return _FunctionModule; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string ZMESKEY
            {
                set { _ZMESKEY = value; }
                get { return _ZMESKEY; }
            }
            /// <summary>
            /// 
            /// </summary>
            public DateTime BLDAT
            {
                set { _BLDAT = value; }
                get { return _BLDAT; }
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
            /// <summary>
            /// 
            /// </summary>
            public string ZUNPLAN
            {
                set { _ZUNPLAN = value; }
                get { return _ZUNPLAN; }
            }

        }

        public class RFC_RMU_LY_ITEM_Model
        {
            private string _ZMESITEM;
            private string _RSNUM;
            private string _RSPOS;
            private string _BWART;
            private string _MATNR;
            private string _WERKS;
            private string _LGORT;
            private int _MENGE;
            private string _MEINS;
            private string _CHARG;
            private string _ITEM_TEXT;

            /// <summary>
            /// 
            /// </summary>
            public string ZMESITEM
            {
                set { _ZMESITEM = value; }
                get { return _ZMESITEM; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string RSNUM
            {
                set { _RSNUM = value; }
                get { return _RSNUM; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string RSPOS
            {
                set { _RSPOS = value; }
                get { return _RSPOS; }
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
            public string MATNR
            {
                set { _MATNR = value; }
                get { return _MATNR; }
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
            public string CHARG
            {
                set { _CHARG = value; }
                get { return _CHARG; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string ITEM_TEXT
            {
                set { _ITEM_TEXT = value; }
                get { return _ITEM_TEXT; }
            }
        }
    }
}
