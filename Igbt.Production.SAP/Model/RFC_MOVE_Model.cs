using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP.Model
{
    public class RFC_MOVE_Model
    {
        private string _FunctionModule;
        private string _MBLNR;
        private string _ZEILE;
        private DateTime _BUDAT;
        private string _MATNR;
        private string _LGORT;
        private string _CHARG;
        private string _MENGE;
        private string _CEINM;
        private string _MEINS;
        private string _BWART;
        private string _AUFNR;
        private string _RSNUM;
        private string _CFLAG;
        private string _MAKTX;
        private string _L_MM_MOVE; 

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
        public string L_MM_MOVE
        {
            set { _L_MM_MOVE = value; }
            get { return _L_MM_MOVE; }

        }

        /// <summary>
        /// 
        /// </summary>
        public string MBLNR
        {
            set { _MBLNR = value; }
            get { return _MBLNR; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ZEILE
        {
            set { _ZEILE = value; }
            get { return _ZEILE; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime I_BUDAT
        {
            set { _BUDAT = value; }
            get { return _BUDAT; }
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
        public string CHARG
        {
            set { _CHARG = value; }
            get { return _CHARG; }
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
        public string MENGE
        {
            set { _MENGE = value; }
            get { return _MENGE; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CEINM
        {
            set { _CEINM = value; }
            get { return _CEINM; }
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
        public string AUFNR
        {
            set { _AUFNR = value; }
            get { return _AUFNR; }
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
        public string MEINS
        {
            set { _MEINS = value; }
            get { return _MEINS; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string CFLAG
        {
            set { _CFLAG = value; }
            get { return _CFLAG; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string MAKTX
        {
            set { _MAKTX = value; }
            get { return _MAKTX; }
        }
    }
}
