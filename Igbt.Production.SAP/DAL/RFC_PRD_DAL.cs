using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.Model;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP.DAL
{
   public class RFC_PRD_DAL
    {
        private IDestinationConfiguration _configurationId;
        private RfcDestination _dest;
        private RfcRepository _repository;

        public IRfcTable Rfc_Prd_Dal(RFC_PRD_Model prdModel, out RFC_IN_Message rfcMessage)
        {
            rfcMessage = new RFC_IN_Message();
            try
            {
                _configurationId = new RFC_SetUp();
                RfcDestinationManager.RegisterDestinationConfiguration(_configurationId);
                _dest = RfcDestinationManager.GetDestination("SAPMS");
                _repository = _dest.Repository;
                IRfcFunction rfc = _repository.CreateFunction("Z_PP_MES_IN_PRD");   //调用函数名                
                IRfcTable table = rfc.GetTable("T_DATA");//RFC表数据
                rfc.SetValue("I_MESKEY", prdModel.I_MESKEY);                                    //KEY随机号 不能重复
                rfc.SetValue("I_DATE", prdModel.I_DATE);                                        //日期
                rfc.SetValue("I_TIME", prdModel.I_TIME);                                        //时间
                rfc.SetValue("I_USER", prdModel.I_USER);                                        //登录名
                rfc.SetValue("I_AUFNR", prdModel.I_AUFNR);                                      //销售订单号            
                rfc.Invoke(_dest);

                rfcMessage.E_RETURN_CODE = rfc.GetString("E_RETURN_CODE").ToString();
                rfcMessage.E_RETURN_MESSAGE = rfc.GetString("E_RETURN_MESSAGE").ToString();
                rfcMessage.E_COUNT = rfc.GetInt("E_COUNT").ToString();
                rfcMessage.E_SUM = rfc.GetInt("E_SUM").ToString();
                return table;
            }
            catch (Exception exception)
            {
                rfcMessage.E_RETURN_MESSAGE = "接口PRD 错误：" + exception.ToString();
                return null;
            }
            finally
            {
                RfcDestinationManager.UnregisterDestinationConfiguration(_configurationId);
            }
        }
    }
}
