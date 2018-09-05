using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.Model;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP.DAL
{
   public class RFC_SPO_DAL
    {
        private IDestinationConfiguration _configurationId;
        private RfcDestination _dest;
        private RfcRepository _repository;

        public IRfcTable Rfc_Spo_Dal(RFC_SPO_Model spoModel, out RFC_IN_Message rfcMessage)
        {
            rfcMessage = new RFC_IN_Message();
            try
            {
                _configurationId = new RFC_SetUp();
                RfcDestinationManager.RegisterDestinationConfiguration(_configurationId);
                _dest = RfcDestinationManager.GetDestination("SAPMS");
                _repository = _dest.Repository;
                IRfcFunction rfc = _repository.CreateFunction(spoModel.FunctionModule);   //调用函数名                
                IRfcTable table = rfc.GetTable(spoModel.E_SAP_SPO);                       //RFC表数据
                rfc.SetValue("I_MESKEY", spoModel.I_MESKEY);                              //KEY随机号 不能重复
                rfc.SetValue("I_DATE", spoModel.I_DATE.ToString("yyyyMMdd"));                                  //日期
                rfc.SetValue("I_TIME", spoModel.I_TIME.ToString("HH:mm:ss"));                                  //时间
                rfc.SetValue("I_USER", spoModel.I_USER);                                  //登录名
                rfc.SetValue("I_EBELN", spoModel.I_EBELN);                                //销售订单号            
                rfc.Invoke(_dest);

                rfcMessage.E_RETURN_CODE = rfc.GetString("E_RETURN_CODE").ToString();
                //rfcMessage.E_RETURN_MESSAGE = rfc.GetString("E_RETURN_MESSAGE").ToString();
                rfcMessage.E_COUNT = rfc.GetInt("E_COUNT").ToString();
                rfcMessage.E_SUM = rfc.GetInt("E_SUM").ToString();
                return table;
            }
            catch (Exception exception)
            {
                rfcMessage.E_RETURN_MESSAGE = "接口SPO 错误：" + exception.ToString();
                return null;
            }
            finally
            {
                RfcDestinationManager.UnregisterDestinationConfiguration(_configurationId);
            }
        }
    }
}
