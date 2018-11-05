using System;
using System.Data;
using System.Windows.Forms;

namespace FireProductManager.ServiceLogicPackage
{
    public class ExcelOperator
    {
        public static void DataSetToExcel(DataSet ds, bool showExcel)
        {
            DataTable dt;
            int rn;
            int cn;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wk = excel.Application.Workbooks.Add(true);
            Microsoft.Office.Interop.Excel.Worksheet ws;
            excel.Visible = showExcel;

            for (int x = 0; x < ds.Tables.Count; x++)
            {
                ws = wk.Worksheets.Add();

                dt = ds.Tables[x];
                ws.Name = dt.TableName;
                rn = dt.Rows.Count;
                cn = dt.Columns.Count;

                //写入列明
                for (int c = 0; c < cn; c++)
                {
                    ws.Cells[1, c + 1] = dt.Columns[c].ColumnName;
                }

                for (int c = 0; c < rn; c++)
                {
                    for (int j = 0; j < cn; j++)
                    {
                        ws.Cells[c + 2, j + 1] = dt.Rows[c].ItemArray[j];
                    }
                }
            }

            DateTime d = System.DateTime.Now;
            string name = "d:\\" + d.ToString("yyyyMMddhhmmss") + ".xlsx";
            //wk.SaveAs(name,Missing.Value, Missing.Value, Missing.Value, Missing.Value
            //    , Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange
            //    , Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            ////wk.Saved = true;
            excel.UserControl = false;

            return;
        }

        private static DataSet DataGridViewAdapter(DataGridView dgv)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dr;

            foreach (DataGridViewColumn dgvc in dgv.Columns)
            {
                dt.Columns.Add(dgvc.HeaderText);
            }
            foreach (DataGridViewRow r in dgv.Rows)
            {
                //int index = r.Index;
                dr = dt.NewRow();

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (r.Cells[i].Value != null)
                        dr[i] = r.Cells[i].Value.ToString();
                    else
                        dr[i] = "";
                }
                dt.Rows.Add(dr);
            }

            ds.Tables.Add(dt);

            return ds;
        }

        public static void DataGridViewToExcel(DataGridView dgv, bool showExcel)
        {
            DataSet ds = DataGridViewAdapter(dgv);
            DataSetToExcel(ds, showExcel);
        }
    }
}