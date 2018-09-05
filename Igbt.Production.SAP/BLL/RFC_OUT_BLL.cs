using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Igbt.Production.SAP.DAL;
using Igbt.Production.SAP.Model;

namespace Igbt.Production.SAP.BLL
{
    public class RFC_OUT_BLL
    {
        #region 公共函数
        private DataTable dtTable = new DataTable();
        private ConvertDataSap convertDataSap = new ConvertDataSap();
        #endregion

        #region 接口函数
        private RFC_FGS_DAL rfcFgsDal = new RFC_FGS_DAL();
        private RFC_MMU_DAL rfcMmuDal = new RFC_MMU_DAL();
        private RFC_QDT_DAL rfcQdtDal = new RFC_QDT_DAL();
        private RFC_SPO_DAL rfcSpoDal = new RFC_SPO_DAL();
        private RFC_BOM_DAL rfcBomDal = new RFC_BOM_DAL();
        private RFC_PRD_DAL rfcPrdDal = new RFC_PRD_DAL();
        private RFC_PCI_DAL rfcPciDal = new RFC_PCI_DAL();
        private RFC_POM_DAL rfcPomDal = new RFC_POM_DAL();
        private RFC_DEL_DAL rfcDelDal = new RFC_DEL_DAL();
        private RFC_SSO_DAL rfcSsoDal = new RFC_SSO_DAL();
        private Z_MM_OPC_FG rfcGoodsDal = new Z_MM_OPC_FG();
        private RFC_STOCK_DAL rfcStock = new RFC_STOCK_DAL();
        private RFC_MOVE_DAL rfcMove = new RFC_MOVE_DAL();
        private RFC_EM_DAL rfcEM= new RFC_EM_DAL();
        #endregion

        #region 函数接口业务逻辑
        /// <summary>
        /// STOCK
        /// </summary>
        /// <param name="fgsModel"></param>
        /// <param name="rfcMessage"></param>
        /// <returns></returns>
        public DataTable Rfc_Stock_DataTable(RFC_STOCK_Model StockModel, out RFC_IN_Message rfcMessage)
        {
            return convertDataSap.ConversionDataTableRFCTable(rfcStock.Rfc_Stock_dal(StockModel, out rfcMessage));
        }

        /// <summary>
        /// EM
        /// </summary>
        /// <param name="fgsModel"></param>
        /// <param name="rfcMessage"></param>
        /// <returns></returns>
        public DataTable Rfc_Em_DataTable(RFC_EM_Model EmModel, out RFC_IN_Message rfcMessage)
        {
            return convertDataSap.ConversionDataTableRFCTable(rfcEM.Rfc_Em_Dal(EmModel, out rfcMessage));
        }

        /// <summary>
        /// MOVE
        /// </summary>
        /// <param name="fgsModel"></param>
        /// <param name="rfcMessage"></param>
        /// <returns></returns>
        public DataTable Rfc_Move_DataTable(RFC_MOVE_Model MoveModel, out RFC_IN_Message rfcMessage)
        {
            return convertDataSap.ConversionDataTableRFCTable(rfcMove.Rfc_Move_Dal(MoveModel, out rfcMessage));
        }

        /// <summary>
        /// FGS
        /// </summary>
        /// <param name="fgsModel"></param>
        /// <param name="rfcMessage"></param>
        /// <returns></returns>
        public DataTable Rfc_Fgs_DataTable(RFC_FGS_Model fgsModel, out RFC_IN_Message rfcMessage)
        {
            return convertDataSap.ConversionDataTableRFCTable(rfcFgsDal.Rfc_Fgs_Dal(fgsModel, out rfcMessage));
        }
        /// <summary>
        /// MMU
        /// </summary>
        /// <param name="mmuModel"></param>
        /// <param name="rfcMessage"></param>
        /// <returns></returns>
        public DataTable Rfc_Mmu_DataTable(RFC_MMU_Model mmuModel, out RFC_IN_Message rfcMessage)
        {
            return convertDataSap.ConversionDataTableRFCTable(rfcMmuDal.Rfc_Mmu_Dal(mmuModel, out rfcMessage));
        }
        /// <summary>
        /// QDT
        /// </summary>
        /// <param name="qdtModel"></param>
        /// <param name="rfcMessage"></param>
        /// <returns></returns>
        public DataTable Rfc_Qdt_DataTable(RFC_QDT_Model qdtModel, out RFC_IN_Message rfcMessage)
        {
            return convertDataSap.ConversionDataTableRFCTable(rfcQdtDal.Rfc_Qdt_Dal(qdtModel, out rfcMessage));
        }
        /// <summary>
        /// SPO
        /// </summary>
        /// <param name="spoModel"></param>
        /// <param name="rfcMessage"></param>
        /// <returns></returns>
        public DataTable Rfc_Spo_DataTable(RFC_SPO_Model spoModel, out RFC_IN_Message rfcMessage)
        {
            return convertDataSap.ConversionDataTableRFCTable(rfcSpoDal.Rfc_Spo_Dal(spoModel, out rfcMessage));
        }
        /// <summary>
        /// BOM
        /// </summary>
        /// <param name="bomModel"></param>
        /// <param name="rfcMessage"></param>
        /// <returns></returns>
        public DataTable Rfc_Bom_DataTable(RFC_BOM_Model bomModel, out RFC_IN_Message rfcMessage)
        {
            return convertDataSap.ConversionDataTableRFCTable(rfcBomDal.Rfc_Bom_Dal(bomModel, out rfcMessage));
        }
        /// <summary>
        /// PRD
        /// </summary>
        /// <param name="prdModel"></param>
        /// <param name="rfcMessage"></param>
        /// <returns></returns>
        public DataTable Rfc_Prd_DataTable(RFC_PRD_Model prdModel, out RFC_IN_Message rfcMessage)
        {
            return convertDataSap.ConversionDataTableRFCTable(rfcPrdDal.Rfc_Prd_Dal(prdModel, out rfcMessage));
        }
        /// <summary>
        /// PCI
        /// </summary>
        /// <param name="pciModel"></param>
        /// <param name="rfcMessage"></param>
        /// <returns></returns>
        public DataTable Rfc_Pci_DataTable(RFC_PCI_Model pciModel, out RFC_IN_Message rfcMessage)
        {
            return convertDataSap.ConversionDataTableRFCTable(rfcPciDal.Rfc_Pci_Dal(pciModel, out rfcMessage));
        }
        /// <summary>
        /// POM
        /// </summary>
        /// <param name="pomModel"></param>
        /// <param name="rfcMessage"></param>
        /// <returns></returns>
        public DataTable Rfc_Pom_DataTable(RFC_POM_Model pomModel, out RFC_IN_Message rfcMessage)
        {
            return convertDataSap.ConversionDataTableRFCTable(rfcPomDal.Rfc_Pom_Dal(pomModel, out rfcMessage));
        }
        /// <summary>
        /// DEL
        /// </summary>
        /// <param name="delModel"></param>
        /// <param name="rfcMessage"></param>
        /// <returns></returns>
        public DataTable Rfc_Del_DataTable(RFC_DEL_Model delModel, out RFC_IN_Message rfcMessage)
        {
            return convertDataSap.ConversionDataTableRFCTable(rfcDelDal.Rfc_Del_Dal(delModel, out rfcMessage));
        }
        /// <summary>
        /// SSO
        /// </summary>
        /// <param name="ssoModel"></param>
        /// <param name="rfcMessage"></param>
        /// <returns></returns>
        public DataTable Rfc_Sso_DataTable(RFC_SSO_Model ssoModel, out RFC_IN_Message rfcMessage)
        {
            return convertDataSap.ConversionDataTableRFCTable(rfcSsoDal.Rfc_Sso_Dal(ssoModel, out rfcMessage));
        }

        /// <summary>
        /// 库存对比
        /// </summary>
        /// <param name="rfcMessage"></param>
        /// <returns></returns>
        public DataTable Z_MM_OPC_FG_Dal(out RFC_IN_Message rfcMessage)
        {
            return convertDataSap.ConversionDataTableRFCTable(rfcGoodsDal.Rfc_Goods_Dal("E", "", "L_STOCKQUERY", out rfcMessage));
        }

        /// <summary>
        ///预留单查询
        /// </summary>
        /// <param name="rfcMessage"></param>
        /// <returns></returns>
        public DataTable Z_MM_OPC_FG_Dal_YL(string I_RSNUM, out RFC_IN_Message rfcMessage)
        {
            return convertDataSap.ConversionDataTableRFCTable(rfcGoodsDal.Rfc_Goods_Dal("B", I_RSNUM, "L_FG_resb", out rfcMessage));
        }

        #endregion
    }
}
