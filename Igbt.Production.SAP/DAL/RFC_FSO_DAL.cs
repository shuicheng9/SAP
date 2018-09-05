using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.Model;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP.DAL
{
    public class RFC_FSO_DAL
    {
        private IDestinationConfiguration _configurationId;
        private RfcDestination _dest;
        private RfcRepository _repository;

        public RFC_OUT_Message Rfc_Fso_Dal(RFC_FSO_Model.RFC_FSO_HEADER_Model fsoHeaderModels)
        {
            RFC_OUT_Message rfcMessage = new RFC_OUT_Message();
            try
            {
                _configurationId = new RFC_SetUp();
                RfcDestinationManager.RegisterDestinationConfiguration(_configurationId);
                _dest = RfcDestinationManager.GetDestination("SAPMS");
                _repository = _dest.Repository;
                IRfcFunction rfc = _repository.CreateFunction("Z_PP_MES_OUT_FSO");   //调用函数名                
                IRfcStructure structure = rfc.GetStructure("I_HEADER");             //RFC表头数据
                structure.SetValue("ZMESKEY", fsoHeaderModels.ZMESKEY);
                structure.SetValue("PLNUM", fsoHeaderModels.PLNUM);
                structure.SetValue("MATNR", fsoHeaderModels.MATNR);
                structure.SetValue("PWWRK", fsoHeaderModels.PWWRK);
                structure.SetValue("PLWRK", fsoHeaderModels.PLWRK);
                structure.SetValue("PAART", fsoHeaderModels.PAART);
                structure.SetValue("MENGE", fsoHeaderModels.MENGE);
                structure.SetValue("MEINS", fsoHeaderModels.MEINS);
                structure.SetValue("PSTTR", fsoHeaderModels.PSTTR);
                structure.SetValue("PEDTR", fsoHeaderModels.PEDTR);
                structure.SetValue("VERID", fsoHeaderModels.VERID);
                structure.SetValue("ZCOUNT", fsoHeaderModels.ZCOUNT);
                structure.SetValue("ZSUM", fsoHeaderModels.ZSUM);
                structure.SetValue("ZUSER", fsoHeaderModels.ZUSER);
                structure.SetValue("ZCLEARFLAG", fsoHeaderModels.ZCLEARFLAG);

                rfc.Invoke(_dest);
                rfcMessage.E_RETURN_CODE = rfc.GetString("E_RETURN_CODE").ToString();
                rfcMessage.E_RETURN_MESSAGE = rfc.GetString("E_RETURN_MESSAGE").ToString();
                rfcMessage.E_PLAN_OR = rfc.GetString("E_PLAN_OR").ToString();
                return rfcMessage;
            }
            catch (Exception exception)
            {
                rfcMessage.E_RETURN_MESSAGE = "接口FSO 错误：" + exception.ToString();
                return null;
            }
            finally
            {
                RfcDestinationManager.UnregisterDestinationConfiguration(_configurationId);
            }
        }





    }
}
