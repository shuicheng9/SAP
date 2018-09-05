using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP.Model
{
   public class RFC_FSO_Model
    {
       public class RFC_FSO_HEADER_Model
       {
           #region FSO表头项目
           private string _FunctionModule;
           private string _ZMESKEY;
           private string _PLNUM;
           private string _MATNR;
           private string _PWWRK;
           private string _PLWRK;
           private string _PAART;
           private int _MENGE;
           private string _MEINS;
           private string _PSTTR;
           private string _PEDTR;
           private string _VERID;
           private int _ZCOUNT;
           private int _ZSUM;
           private string _ZUSER;
           private string _ZCLEARFLAG;
           private string _E_SAP_FSO;

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
           public string E_SAP_FSO
           {
               set { _E_SAP_FSO = value; }
               get { return _E_SAP_FSO; }

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
           /// 计划订单号
           /// </summary>
           public string PLNUM
           {
               set { _PLNUM = value; }
               get { return _PLNUM; }
           }
           /// <summary>
           /// 计划物料
           /// </summary>
           public string MATNR
           {
               set { _MATNR = value; }
               get { return _MATNR; }
           }
           /// <summary>
           /// 计划订单中的生产工厂
           /// </summary>
           public string PWWRK
           {
               set { _PWWRK = value; }
               get { return _PWWRK; }
           }
           /// <summary>
           /// 计划工厂
           /// </summary>
           public string PLWRK
           {
               set { _PLWRK = value; }
               get { return _PLWRK; }
           }
           /// <summary>
           /// 订单类型
           /// </summary>
           public string PAART
           {
               set { _PAART = value; }
               get { return _PAART; }
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
           /// 计划订单上的订单开始日期 
           /// </summary>
           public string PSTTR
           {
               set { _PSTTR = value; }
               get { return _PSTTR; }
           }
           /// <summary>
           /// 计划订单中的订单结束日期
           /// </summary>
           public string PEDTR
           {
               set { _PEDTR = value; }
               get { return _PEDTR; }
           }
           /// <summary>
           /// 生产版本
           /// </summary>
           public string VERID
           {
               set { _VERID = value; }
               get { return _VERID; }
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
           /// 清除标志(X:清除已存在的计划订单)
           /// </summary>
           public string ZCLEARFLAG
           {
               set { _ZCLEARFLAG = value; }
               get { return _ZCLEARFLAG; }
           }
           #endregion
       }
    }
}
