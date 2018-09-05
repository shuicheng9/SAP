using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP.Model
{
    public class RFC_FGU_Model
    {
        /// <summary>
        /// 
        /// </summary>
        public class RFC_FGU_HEADER_Model
        {
            private string _FunctionModule;
            private string _ZMESKEY;
            private string _VBELN;
            private DateTime _WADAT_IST;
            private int _ZCOUNT;
            private int _ZSUM;
            private string _ZUSER;
            private string _ZSTEP;
            private string _E_SAP_FGU;

            /// <summary>
            /// SAP函数接口名称
            /// </summary>
            public string FunctionModule
            {
                set { _FunctionModule = value; }
                get { return _FunctionModule; }
            }
            /// <summary>
            /// SAP表明
            /// </summary>
            public string E_SAP_FGU
            {
                set { _E_SAP_FGU = value; }
                get { return _E_SAP_FGU; }
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
            /// 交货
            /// </summary>
            public string VBELN
            {
                set { _VBELN = value; }
                get { return _VBELN; }
            }
            /// <summary>
            /// 实际货物移动日期
            /// </summary>
            public DateTime WADAT_IST
            {
                set { _WADAT_IST = value; }
                get { return _WADAT_IST; }
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
            /// 步骤(1:分配批次;2:发货;3:发货冲销)
            /// </summary>
            public string ZSTEP
            {
                set { _ZSTEP = value; }
                get { return _ZSTEP; }
            }

        }
        public class RFC_FGU_ITEM_Model
        {
            private string _ZMESITEM;
            private string _POSNR;
            private string _MATNR;
            private int _MENGE;
            private string _MEINS;
            private string _CHARG;
            private string _ZLOTNO;
            private string _ZINBOXNO;
            private int _LOTQTY;

            /// <summary>
            /// MES行号
            /// </summary>
            public string ZMESITEM
            {
                set { _ZMESITEM = value; }
                get { return _ZMESITEM; }
            }
            /// <summary>
            /// 交货项目
            /// </summary>
            public string POSNR
            {
                set { _POSNR = value; }
                get { return _POSNR; }
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
            /// 数量
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
            /// 批号
            /// </summary>
            public string CHARG
            {
                set { _CHARG = value; }
                get { return _CHARG; }
            }
            /// <summary>
            /// Lot号 
            /// </summary>
            public string ZLOTNO
            {
                set { _ZLOTNO = value; }
                get { return _ZLOTNO; }
            }
            /// <summary>
            /// 小箱号 
            /// </summary>
            public string ZINBOXNO
            {
                set { _ZINBOXNO = value; }
                get { return _ZINBOXNO; }
            }
            /// <summary>
            /// 数量
            /// </summary>
            public int LOTQTY
            {
                set { _LOTQTY = value; }
                get { return _LOTQTY; }
            }
        }
    }
}
