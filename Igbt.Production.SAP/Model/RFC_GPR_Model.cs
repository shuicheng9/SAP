using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP.Model
{
   public class RFC_GPR_Model
    {
       public class RFC_GPR_HEADER_Model
       {
           #region GRP表头项目
           private string _FunctionModule;
           private string _ZMESKEY;
           private string _EBELN;
           private string _BUKRS;
           private string _BSART;
           private string _EKORG;
           private DateTime _AEDAT;
           private string _LIFNR;
           private int _ZCOUNT;
           private int _ZSUM;
           private string _ZUSER;
           private string _E_SAP_GRP;

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
           public string E_SAP_GRP
           {
               set { _E_SAP_GRP = value; }
               get { return _E_SAP_GRP; }

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
           /// 采购凭证号
           /// </summary>
           public string EBELN
           {
               set { _EBELN = value; }
               get { return _EBELN; }
           }
           /// <summary>
           /// 公司代码
           /// </summary>
           public string BUKRS
           {
               set { _BUKRS = value; }
               get { return _BUKRS; }
           }
           /// <summary>
           /// 采购凭证类型
           /// </summary>
           public string BSART
           {
               set { _BSART = value; }
               get { return _BSART; }
           }
           /// <summary>
           /// 采购组织
           /// </summary>
           public string EKORG
           {
               set { _EKORG = value; }
               get { return _EKORG; }
           }
           /// <summary>
           /// 采购凭证日期
           /// </summary>
           public DateTime AEDAT
           {
               set { _AEDAT = value; }
               get { return _AEDAT; }
           }
           /// <summary>
           /// 供应商帐户号
           /// </summary>
           public string LIFNR
           {
               set { _LIFNR = value; }
               get { return _LIFNR; }
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
           #endregion
       }

       public class RFC_GPR_ITEM_Model
       {
           #region GRP行项目
           private string _ZMESITEM;
           private string _EBELP;
           private string _LOEKZ;
           private string _MATNR;
           private string _WERKS;
           private string _LGORT;
           private int _MENGE;
           private string _MEINS;
           private DateTime _EINDT;
           private string _LICHA;
           private string _ZJPSONO;
           private string _ZJPSOITEM;

           /// <summary>
           /// MES行号
           /// </summary>
           public string ZMESITEM
           {
               set { _ZMESITEM = value; }
               get { return _ZMESITEM; }
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
           /// 采购凭证中的删除标识
           /// </summary>
           public string LOEKZ
           {
               set { _LOEKZ = value; }
               get { return _LOEKZ; }
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
           /// 采购订单数量
           /// </summary>
           public int MENGE
           {
               set { _MENGE = value; }
               get { return _MENGE; }
           }
           /// <summary>
           /// 采购订单的计量单位 
           /// </summary>
           public string MEINS
           {
               set { _MEINS = value; }
               get { return _MEINS; }
           }
           /// <summary>
           /// 项目交货日期
           /// </summary>
           public DateTime EINDT
           {
               set { _EINDT = value; }
               get { return _EINDT; }
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
           /// 日本销售订单 
           /// </summary>
           public string ZJPSONO
           {
               set { _ZJPSONO = value; }
               get { return _ZJPSONO; }
           }
           /// <summary>
           /// 日本销售订单行
           /// </summary>
           public string ZJPSOITEM
           {
               set { _ZJPSOITEM = value; }
               get { return _ZJPSOITEM; }
           }
           #endregion
       }
    }
}
