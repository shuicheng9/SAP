using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SAP.Middleware.Connector;

namespace Igbt.Production.SAP
{
    public class ConvertDataSap
    {
        /// <summary>
        /// RFC数据转换成DataTable类型
        /// </summary>
        /// <param name="myrfcTable"></param>
        /// <returns></returns>
        public DataTable ConversionDataTableRFCTable( IRfcTable myrfcTable)//处理SAP数据 返回 datatabl
        {
            DataTable loTable1 = new DataTable();
            if (myrfcTable == null)
            {
                return loTable1;
            }
            int liElement = 0;
            for (liElement = 0; liElement <= myrfcTable.ElementCount - 1; liElement++)
            {
                RfcElementMetadata metadata = myrfcTable.GetElementMetadata(liElement);
                loTable1.Columns.Add(metadata.Name);
            }
            foreach (IRfcStructure Row in myrfcTable)
            {
                DataRow ldr = loTable1.NewRow();
                for (liElement = 0; liElement <= myrfcTable.ElementCount - 1; liElement++)
                {
                    RfcElementMetadata metadata = myrfcTable.GetElementMetadata(liElement);
                    ldr[metadata.Name] = Row.GetString(metadata.Name);
                }
                loTable1.Rows.Add(ldr);
            }
            return loTable1;
        }
    }
}
