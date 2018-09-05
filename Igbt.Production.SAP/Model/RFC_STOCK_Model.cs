using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP.Model
{
    public class RFC_STOCK_Model
    {
        private string _FunctionModule;
        private string _MATNR;
        private string _WERKS;
        private string _LGORT;
        private string _CHARG;
        private string _CLABS;
        private string _CINSM;
        private string _CSPEM;
        private string _CEINM;
        private string _MEINS;
        private DateTime _ERSDA;
        private DateTime _UZEIT;
        private string _MAKTX;
        private string _L_MM_STOCK;  

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
        public string L_MM_STOCK
        {
            set { _L_MM_STOCK = value; }
            get { return _L_MM_STOCK; }

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
        public  DateTime ERSDA
        {
            set { _ERSDA = value; }
            get { return _ERSDA; }
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
        public string CHARG
        {
            set { _CHARG = value; }
            get { return _CHARG; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLABS
        {
            set { _CLABS = value; }
            get { return _CLABS; }
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
        public string CSPEM
        {
            set { _CSPEM = value; }
            get { return _CSPEM; }
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
        public DateTime UZEIT
        {
            set { _UZEIT = value; }
            get { return _UZEIT; }
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
