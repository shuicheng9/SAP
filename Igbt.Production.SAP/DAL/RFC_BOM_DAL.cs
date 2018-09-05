using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.Model;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP.DAL
{
     public class RFC_BOM_DAL
    {
        private IDestinationConfiguration _configurationId;
        private RfcDestination _dest;
        private RfcRepository _repository;

        public IRfcTable Rfc_Bom_Dal(RFC_BOM_Model bomModel, out RFC_IN_Message rfcMessage)
        {
            rfcMessage = new RFC_IN_Message();
            try
            {
                _configurationId = new RFC_SetUp();
                RfcDestinationManager.RegisterDestinationConfiguration(_configurationId);
                _dest = RfcDestinationManager.GetDestination("SAPMS");
                _repository = _dest.Repository;
                IRfcFunction rfc = _repository.CreateFunction(bomModel.FunctionModule);   //调用函数名                
                IRfcTable table = rfc.GetTable(bomModel.E_SAP_BOM);//RFC表数据
                rfc.SetValue("I_MESKEY", bomModel.I_MESKEY);                         //KEY随机号 不能重复
                rfc.SetValue("I_DATE", bomModel.I_DATE);                                                  //日期
                rfc.SetValue("I_TIME", bomModel.I_TIME);                                                 //时间
                rfc.SetValue("I_USER", bomModel.I_USER);                                                  //登录名
                rfc.SetValue("I_MATNR", bomModel.I_MATNR);                                      //销售订单号            
                rfc.Invoke(_dest);

                rfcMessage.E_RETURN_CODE = rfc.GetString("E_RETURN_CODE").ToString();
                rfcMessage.E_RETURN_MESSAGE = rfc.GetString("E_RETURN_MESSAGE").ToString();
                //rfcMessage.E_COUNT = rfc.GetInt("E_COUNT").ToString();
                //rfcMessage.E_SUM = rfc.GetInt("E_SUM").ToString();
                return table;
            }
            catch (Exception exception)
            {
                rfcMessage.E_RETURN_MESSAGE = "接口BOM 错误：" + exception.ToString();
                return null;
            }
            finally
            {
                RfcDestinationManager.UnregisterDestinationConfiguration(_configurationId);
            }
        }

    }
}
