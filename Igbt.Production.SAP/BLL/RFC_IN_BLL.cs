using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.DAL;
using Igbt.Production.SAP.Model;

namespace Igbt.Production.SAP.BLL
{
    public class RFC_IN_BLL
    {
        #region 接口函数
        private RFC_GRP_DAL rfcGrpDal = new RFC_GRP_DAL();
        private RFC_GRW_DAL rfcGrwDal = new RFC_GRW_DAL();
        private RFC_STU_DAL rfcStuDal = new RFC_STU_DAL();
        private RFC_FGO_DAL rfcFgoDal = new RFC_FGO_DAL();
        private RFC_FSO_DAL rfcFsoDal = new RFC_FSO_DAL();
        private RFC_RMU_DAL rfcRmuDal = new RFC_RMU_DAL();
        private RFC_RMU_LY_DAL rfcRmuLyDal = new RFC_RMU_LY_DAL();
        private RFC_WTC_DAL rfcWtcDal = new RFC_WTC_DAL();
        private RFC_FGU_DAL rfcFguDal = new RFC_FGU_DAL();
        #endregion

        #region 函数接口业务逻辑

        public RFC_OUT_Message Rfc_Gpr_Dal(List<RFC_GPR_Model.RFC_GPR_ITEM_Model> gprItemModels,RFC_GPR_Model.RFC_GPR_HEADER_Model gprHeaderModel)
        {
            return rfcGrpDal.Rfc_Gpr_Dal(gprItemModels, gprHeaderModel);
        }

        public RFC_OUT_Message Rfc_Grw_Dal(List<RFC_GRW_Model.RFC_GRW_ITEM_Model> grwItemModels, RFC_GRW_Model.RFC_GRW_HEADER_Model grwHeaderModel)
        {
            return rfcGrwDal.Rfc_Grw_Dal(grwItemModels, grwHeaderModel);
        }

        public RFC_OUT_Message Rfc_Stu_Dal(List<RFC_STU_Model.RFC_STU_ITEM_Model> stuItemModels, RFC_STU_Model.RFC_STU_HEADER_Model stuHeaderModel)
        {
            return rfcStuDal.Rfc_Stu_Dal(stuItemModels, stuHeaderModel);
        }

        public RFC_OUT_Message Rfc_Fgo_Dal(List<RFC_FGO_Model.RFC_FGO_ITEM_Model> fgoItemModels, RFC_FGO_Model.RFC_FGO_HEADER_Model fgoHeaderModel)
        {
            return rfcFgoDal.Rfc_Fgo_Dal(fgoItemModels, fgoHeaderModel);
        }

        public RFC_OUT_Message Rfc_Fso_Dal(RFC_FSO_Model.RFC_FSO_HEADER_Model fsoHeaderModel)
        {
            return rfcFsoDal.Rfc_Fso_Dal(fsoHeaderModel);
        }

        public RFC_OUT_Message Rfc_Rmu_Dal(List<RFC_RMU_Model.RFC_RMU_ITEM_Model> rmuItemModels, RFC_RMU_Model.RFC_RMU_HEADER_Model rmuHeaderModel)
        {
            return rfcRmuDal.Rfc_Rmu_Dal(rmuItemModels, rmuHeaderModel);
        }

        public RFC_OUT_Message Rfc_RmuLy_Dal(List<RFC_RMU_LY_Model.RFC_RMU_LY_ITEM_Model> rmulyItemModels, RFC_RMU_LY_Model.RFC_RMU_LY_HEADER_Model rmulyHeaderModel)
        {
            return rfcRmuLyDal.Rfc_Rmu_Ly_Dal(rmulyItemModels, rmulyHeaderModel);
        }

        public RFC_OUT_Message Rfc_Wtc_Dal( RFC_WTC_Model.RFC_WTC_HEADER_Model wtcHeaderModel)
        {
            return rfcWtcDal.Rfc_Wtc_Dal(wtcHeaderModel);
        }

        public RFC_OUT_Message Rfc_Fgu_Dal(List<RFC_FGU_Model.RFC_FGU_ITEM_Model> fguItemModels, RFC_FGU_Model.RFC_FGU_HEADER_Model fguHeaderModel)
        {
            return rfcFguDal.Rfc_Fgu_Dal(fguItemModels, fguHeaderModel);
        }
        #endregion
        
    }
}
