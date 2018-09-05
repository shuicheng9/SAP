using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP.Model
{
    public class RFC_EM_Model
    {
        private string _FunctionModule;
        private string _MATNR;
        private string _MAKTX;
        private string _LGORT;
        private string _CHARG;
        private string _MEINS;
        private string _CINSM;
        private string _PRFRQ;
        private string _CEINM;
        private string _MHDHB;
        private DateTime _BUDAT_1;
        private DateTime _HSDAT;
        private DateTime _BUDAT;
        private string _MBLNR;

        private string _MBLNR_1;
        private string _L_MM_EM;

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
        public string L_MM_EM
        {
            set { _L_MM_EM = value; }
            get { return _L_MM_EM; }

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
        public string CINSM
        {
            set { _CINSM = value; }
            get { return _CINSM; }
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
        public string PRFRQ
        {
            set { _PRFRQ = value; }
            get { return _PRFRQ; }
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
        public string MHDHB
        {
            set { _MHDHB = value; }
            get { return _MHDHB; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime BUDAT_1
        {
            set { _BUDAT_1 = value; }
            get { return _BUDAT_1; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime HSDAT
        {
            set { _HSDAT = value; }
            get { return _HSDAT; }
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
        public string MBLNR
        {
            set { _MBLNR = value; }
            get { return _MBLNR; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string MAKTX
        {
            set { _MAKTX = value; }
            get { return _MAKTX; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string MBLNR_1
        {
            set { _MBLNR_1 = value; }
            get { return _MBLNR_1; }
        }
    }
}
