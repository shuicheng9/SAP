using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP.Model
{
    public class RFC_WTC_Model
    {
        public class RFC_WTC_HEADER_Model
        {
            private string _FunctionModule;
            private string _ZMESKEY;
            private string _AUFNR;
            private string _AUART;
            private string _MATNR;
            private string _WERKS;
            private int _MENGE;
            private string _MEINS;
            private string _GLTRP;
            private string _GSTRP;
            private int _ZCOUNT;
            private int _ZSUM;
            private string _ZUSER;
            private string _ZDELFLAG;
            private string _E_SAP_WTC;

            /// <summary>
            /// 函数
            /// </summary>
            public string FunctionModule
            {
                set { _FunctionModule = value; }
                get { return _FunctionModule; }
            }
            /// <summary>
            /// SAP表明
            /// </summary>
            public string E_SAP_WTC
            {
                set { _E_SAP_WTC = value; }
                get { return _E_SAP_WTC; }
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
            /// 订单号 
            /// </summary>
            public string AUFNR
            {
                set { _AUFNR = value; }
                get { return _AUFNR; }
            }
            /// <summary>
            /// 订单类型
            /// </summary>
            public string AUART
            {
                set { _AUART = value; }
                get { return _AUART; }
            }
            /// <summary>
            /// 物料号
            /// </summary>
            public string MATNR
            {
                set { _MATNR = value; }
                get { return _MATNR; }
            }
            /// <summary>
            /// 工厂
            /// </summary>
            public string WERKS
            {
                set { _WERKS = value; }
                get { return _WERKS; }
            }
            /// <summary>
            /// 订单数量总计
            /// </summary>
            public int MENGE
            {
                set { _MENGE = value; }
                get { return _MENGE; }
            }
            /// <summary>
            /// 基本计量单位
            /// </summary>
            public string MEINS
            {
                set { _MEINS = value; }
                get { return _MEINS; }
            }
            /// <summary>
            /// 基本完成日期
            /// </summary>
            public string GLTRP
            {
                set { _GLTRP = value; }
                get { return _GLTRP; }
            }
            /// <summary>
            /// 基本开始日期 
            /// </summary>
            public string GSTRP
            {
                set { _GSTRP = value; }
                get { return _GSTRP; }
            }

            /// <summary>
            /// 记录条数
            /// </summary>
            public int ZCOUNT
            {
                set { _ZCOUNT = value; }
                get { return _ZCOUNT; }
            }
            /// <summary>
            /// 记录数量合计
            /// </summary>
            public int ZSUM
            {
                set { _ZSUM = value; }
                get { return _ZSUM; }
            }
            /// <summary>
            /// 创建对象的人员名称 
            /// </summary>
            public string ZUSER
            {
                set { _ZUSER = value; }
                get { return _ZUSER; }
            }
            /// <summary>
            /// 删除标识
            /// </summary>
            public string ZDELFLAG
            {
                set { _ZDELFLAG = value; }
                get { return _ZDELFLAG; }
            }
        }
    }
}
