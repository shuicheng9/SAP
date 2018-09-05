using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.Model;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP.DAL
{
    public class RFC_WTC_DAL
    {
        private IDestinationConfiguration _configurationId;
        private RfcDestination _dest;
        private RfcRepository _repository;

        public RFC_OUT_Message Rfc_Wtc_Dal(RFC_WTC_Model.RFC_WTC_HEADER_Model wtcHeaderModels)
        {
            RFC_OUT_Message rfcMessage = new RFC_OUT_Message();
            try
            {
                _configurationId = new RFC_SetUp();
                RfcDestinationManager.RegisterDestinationConfiguration(_configurationId);
                _dest = RfcDestinationManager.GetDestination("SAPMS");
                _repository = _dest.Repository;
                IRfcFunction rfc = _repository.CreateFunction(wtcHeaderModels.FunctionModule);   //调用函数名                
                                           //RFC表数据
                IRfcStructure structure = rfc.GetStructure("I_HEADER");             //RFC表头数据
                structure.SetValue("ZMESKEY", wtcHeaderModels.ZMESKEY);
                structure.SetValue("AUFNR", wtcHeaderModels.AUFNR);
                structure.SetValue("AUART", wtcHeaderModels.AUART);
                structure.SetValue("MATNR", wtcHeaderModels.MATNR);
                structure.SetValue("WERKS", wtcHeaderModels.WERKS);
                structure.SetValue("MENGE", wtcHeaderModels.MENGE);
                structure.SetValue("MEINS", wtcHeaderModels.MEINS);
                structure.SetValue("GLTRP", wtcHeaderModels.GLTRP);
                structure.SetValue("GSTRP", wtcHeaderModels.GSTRP);
                structure.SetValue("ZCOUNT", wtcHeaderModels.ZCOUNT);
                structure.SetValue("ZSUM", wtcHeaderModels.ZSUM);
                structure.SetValue("ZUSER", wtcHeaderModels.ZUSER);
                structure.SetValue("ZDELFLAG", wtcHeaderModels.ZDELFLAG);

                rfc.Invoke(_dest);
                rfcMessage.E_RETURN_CODE = rfc.GetString("E_RETURN_CODE").ToString();
                rfcMessage.E_RETURN_MESSAGE = rfc.GetString("E_RETURN_MESSAGE").ToString();
                rfcMessage.E_PRD_ORD_NO = rfc.GetString("E_PRD_ORD_NO").ToString();
                rfcMessage.E_EXPROC = rfc.GetString("E_EXPROC").ToString();
                rfcMessage.E_PRD_CHARG = rfc.GetString("E_PRD_CHARG").ToString();
                return rfcMessage;
            }
            catch (Exception exception)
            {
                rfcMessage.E_RETURN_MESSAGE = "接口WTC 错误：" + exception.ToString();
                return null;
            }
            finally
            {
                RfcDestinationManager.UnregisterDestinationConfiguration(_configurationId);
            }
        }

    }
}
