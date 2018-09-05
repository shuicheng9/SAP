using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.Model;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP.DAL
{
   public class RFC_PCI_DAL
    {
        private IDestinationConfiguration _configurationId;
        private RfcDestination _dest;
        private RfcRepository _repository;

        public IRfcTable Rfc_Pci_Dal(RFC_PCI_Model pciModel, out RFC_IN_Message rfcMessage)
        {
            rfcMessage = new RFC_IN_Message();
            try
            {
                _configurationId = new RFC_SetUp();
                RfcDestinationManager.RegisterDestinationConfiguration(_configurationId);
                _dest = RfcDestinationManager.GetDestination("SAPMS");
                _repository = _dest.Repository;
                IRfcFunction rfc = _repository.CreateFunction("Z_PP_MES_IN_PCI");   //调用函数名                
                IRfcTable table = rfc.GetTable("T_DATA");                             //RFC表数据
                rfc.SetValue("I_MESKEY", pciModel.I_MESKEY);                                        //KEY随机号 不能重复
                rfc.SetValue("I_DATE", pciModel.I_DATE);                                                  //日期
                rfc.SetValue("I_TIME", pciModel.I_TIME);                                                 //时间
                rfc.SetValue("I_USER", pciModel.I_USER);                                                  //登录名
                rfc.SetValue("I_AUFNR", pciModel.I_AUFNR);                                              
                rfc.Invoke(_dest);

                rfcMessage.E_RETURN_CODE = rfc.GetString("E_RETURN_CODE").ToString();
                //rfcMessage.E_RETURN_MESSAGE = rfc.GetString("E_RETURN_MESSAGE").ToString();
                rfcMessage.E_COUNT = rfc.GetInt("E_COUNT").ToString();
                rfcMessage.E_SUM = rfc.GetString("E_SUM");
                return table;
            }
            catch (Exception exception)
            {
                rfcMessage.E_RETURN_MESSAGE = "接口PCI 错误：" + exception.ToString();
                return null;
            }
            finally
            {
                RfcDestinationManager.UnregisterDestinationConfiguration(_configurationId);
            }
        }
    }
}
