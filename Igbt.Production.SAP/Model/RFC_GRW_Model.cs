using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP.Model
{
    public class RFC_GRW_Model
    {
        public class RFC_GRW_HEADER_Model
        {
            private string _FunctionModule;
            private string _ZMESKEY;
            private DateTime _BUDAT;
            private string _XBLNR;
            private int _ZCOUNT;
            private decimal _ZSUM;
            private string _ZUSER;
            private string _BKTXT;
            private string _E_SAP_GRW;

            /// <summary>
            /// SAP函数接口名称
            /// </summary>
            public string FunctionModule
            {
                set { _FunctionModule = value; }
                get { return _FunctionModule; }
            }
            /// <summary>
            /// SAP数据表
            /// </summary>
            public string E_SAP_GRW
            {
                set { _E_SAP_GRW = value; }
                get { return _E_SAP_GRW; }
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
            /// 凭证中的过帐日期
            /// </summary>
            public DateTime BUDAT
            {
                set { _BUDAT = value; }
                get { return _BUDAT; }
            }
            /// <summary>
            /// 参考凭证号
            /// </summary>
            public string XBLNR
            {
                set { _XBLNR = value; }
                get { return _XBLNR; }
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
            public decimal  ZSUM
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
            /// 凭证抬头文本
            /// </summary>
            public string BKTXT
            {
                set { _BKTXT = value; }
                get { return _BKTXT; }
            }
        }

        public class RFC_GRW_ITEM_Model
        {
            private string _ZMESITEM;
            private string _EBELN;
            private string _EBELP;
            private string _BWART;
            private string _MATNR;
            private string _WERKS;
            private string _LGORT;
            private int _MENGE;
            private string _MEINS;
            private string _LICHA;
            private string _CHARG;

            /// <summary>
            /// MES行号
            /// </summary>
            public string ZMESITEM
            {
                set { _ZMESITEM = value; }
                get { return _ZMESITEM; }
            }
            /// <summary>
            /// 采购凭证号 
            /// </summary>
            public string EBELN
            {
                set { _EBELN = value; }
                get { return _EBELN; }
            }
            /// <summary>
            /// 采购凭证的项目编号 
            /// </summary>
            public string EBELP
            {
                set { _EBELP = value; }
                get { return _EBELP; }
            }
            /// <summary>
            /// 移动类型（库存管理）
            /// </summary>
            public string BWART
            {
                set { _BWART = value; }
                get { return _BWART; }
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
            /// 库存地点
            /// </summary>
            public string LGORT
            {
                set { _LGORT = value; }
                get { return _LGORT; }
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
            /// 供应商的批次
            /// </summary>
            public string LICHA
            {
                set { _LICHA = value; }
                get { return _LICHA; }
            }
            /// <summary>
            /// 批号
            /// </summary>
            public string CHARG
            {
                set { _CHARG = value; }
                get { return _CHARG; }
            }
        }
    }
}
