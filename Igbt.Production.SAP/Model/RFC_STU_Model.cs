using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP.Model
{
    public class RFC_STU_Model
    {
        public class RFC_STU_HEADER_Model
        {
            private string _FunctionModule;
            private string _ZMESKEY;
            private DateTime _BUDAT;
            private int _ZCOUNT;
            private decimal _ZSUM;
            private string _ZUSER;
            private string _BKTXT;
            private string _E_SAP_STU;

            public string FunctionModule
            {
                set { _FunctionModule = value; }
                get { return _FunctionModule; }
            }
            public string ZMESKEY
            {
                set { _ZMESKEY = value; }
                get { return _ZMESKEY; }
            }
            public DateTime BUDAT
            {
                set { _BUDAT = value; }
                get { return _BUDAT; }
            }
            public int ZCOUNT
            {
                set { _ZCOUNT = value; }
                get { return _ZCOUNT; }
            }
            public decimal ZSUM
            {
                set { _ZSUM = value; }
                get { return _ZSUM; }
            }
            public string ZUSER
            {
                set { _ZUSER = value; }
                get { return _ZUSER; }
            }
            public string BKTXT
            {
                set { _BKTXT = value; }
                get { return _BKTXT; }
            }
            public string E_SAP_STU
            {
                set { _E_SAP_STU = value; }
                get { return _E_SAP_STU; }
            }
        }

        public class RFC_STU_ITEM_Model
        {
            private string _ZMESITEM;
            private string _BWART;
            private string _MATNR;
            private string _WERKS;
            private string _LGORT;
            private decimal  _MENGE;
            private string _MEINS;
            private string _CHARG;
            private string _ZEILE;
            private string _UMLGO;
            private string _LIFNR;
            private string _SOBKZ;

            public string ZMESITEM
            {
                set { _ZMESITEM = value; }
                get { return _ZMESITEM; }
            }
            public string BWART
            {
                set { _BWART = value; }
                get { return _BWART; }
            }
            public string MATNR
            {
                set { _MATNR = value; }
                get { return _MATNR; }
            }
            public string WERKS
            {
                set { _WERKS = value; }
                get { return _WERKS; }
            }
            public string LGORT
            {
                set { _LGORT = value; }
                get { return _LGORT; }
            }
            public decimal  MENGE
            {
                set { _MENGE = value; }
                get { return _MENGE; }
            }
            public string MEINS
            {
                set { _MEINS = value; }
                get { return _MEINS; }
            }
            public string CHARG
            {
                set { _CHARG = value; }
                get { return _CHARG; }
            }
            public string ZEILE
            {
                set { _ZEILE = value; }
                get { return _ZEILE; }
            }
            public string UMLGO
            {
                set { _UMLGO = value; }
                get { return _UMLGO; }
            }
            public string LIFNR
            {
                set { _LIFNR = value; }
                get { return _LIFNR; }
            }
            public string SOBKZ
            {
                set { _SOBKZ = value; }
                get { return _SOBKZ; }
            }
        }
    }
}
