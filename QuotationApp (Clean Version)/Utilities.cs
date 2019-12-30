using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuotationApp__Clean_Version_
{
    public class Utilities
    {
        public void ExportToExcel(List<Material> materials, double total, string productName)
        {
            try
            {
                Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

                excelApp.Visible = true;

                var workbook = excelApp.Workbooks.Add();

                //workbook.TableStyles 

                //**************************More Details***************************************


                //**********************
                Excel._Worksheet workSheet2 = (Excel.Worksheet)excelApp.ActiveSheet;
                workSheet2.Name = "Details";
                var row = 1;

                workSheet2.Cells[row, "A"] = "Qty";
                workSheet2.Cells[row, "B"] = "Material Name";
                workSheet2.Cells[row, "C"] = "Material Cost";
                workSheet2.Cells[row, "D"] = "Setup Hr";
                workSheet2.Cells[row, "E"] = "Setup $/Hr";
                workSheet2.Cells[row, "F"] = "Operation Hr";
                workSheet2.Cells[row, "G"] = "Operation $/Hr";

                workSheet2.Cells[row, "H"] = "Markup";
                workSheet2.Cells[row, "I"] = "Unit Price";
                workSheet2.Cells[row, "J"] = "SubTotal";
                workSheet2.Cells[row, "A"].EntireRow.Font.Bold = true;

                foreach (var mat in materials)
                {
                    row++;
                    workSheet2.Cells[row, "A"] = mat.Qty;
                    workSheet2.Cells[row, "B"] = mat.Name;
                    workSheet2.Cells[row, "C"] = string.Format("{0:C2}", mat.Material_Cost);
                    workSheet2.Cells[row, "D"] = mat.Setup_Hr;
                    workSheet2.Cells[row, "E"] = string.Format("{0:C2}", mat.Setup_Cost);
                    workSheet2.Cells[row, "F"] = mat.Operation_Hr;
                    workSheet2.Cells[row, "G"] = string.Format("{0:C2}", mat.Operation_Cost);
                    workSheet2.Cells[row, "H"] = mat.Markup;
                    workSheet2.Cells[row, "I"] = string.Format("{0:C2}", mat.Price_Per_Piece);
                    workSheet2.Cells[row, "J"] = string.Format("{0:C2}", mat.SubTotal);
                }

                row++;
                row++;
                workSheet2.Cells[row, "I"] = "Total";
                workSheet2.Cells[row, "I"].EntireRow.Font.Bold = true;
                workSheet2.Cells[row, "J"] = string.Format("{0:C2}", total);

                workSheet2.Columns[1].AutoFit();
                workSheet2.Columns[2].AutoFit();
                workSheet2.Columns[3].AutoFit();
                workSheet2.Columns[4].AutoFit();
                workSheet2.Columns[5].AutoFit();
                workSheet2.Columns[6].AutoFit();
                workSheet2.Columns[7].AutoFit();
                workSheet2.Columns[8].AutoFit();
                workSheet2.Columns[9].AutoFit();
                workSheet2.Columns[10].AutoFit();

                workbook.Worksheets.Add();
                //**************************Overview***************************************

                Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
                workSheet.Name = "Summary";
                row = 1;

                workSheet.Cells[row, "A"] = "Qty";
                workSheet.Cells[row, "B"] = "Material Name";
                workSheet.Cells[row, "C"] = "Unit Price";
                workSheet.Cells[row, "D"] = "SubTotal";
                workSheet.Cells[row, "A"].EntireRow.Font.Bold = true;
                //workSheet.Cells[row, "A"].EntireRow.Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; //actually this is actually centered.


                foreach (var mat in materials)
                {
                    row++;
                    workSheet.Cells[row, "A"] = mat.Qty;
                    workSheet.Cells[row, "B"] = mat.Name;
                    workSheet.Cells[row, "C"] = string.Format("{0:C2}", mat.Price_Per_Piece);
                    workSheet.Cells[row, "D"] = string.Format("{0:C2}", mat.SubTotal);
                }

                row++;
                row++;
                workSheet.Cells[row, "C"] = "Total";
                workSheet.Cells[row, "D"] = string.Format("{0:C2}", total);
                workSheet.Cells[row, "A"].EntireRow.Font.Bold = true;


                workSheet.Columns[1].AutoFit();
                workSheet.Columns[2].AutoFit();
                workSheet.Columns[3].AutoFit();
                workSheet.Columns[4].AutoFit();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
