using System;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;

namespace Library
{
    class InventoryBookExcel
    {
        DBTables dBTables = new DBTables();

        public void InventoryBookFill() //заполнение data table
        {
            dBTables.DTInventoryBookFill();
            CreateInventoryBook();
        }

        private void CreateInventoryBook()  //создание документа
        {
            excel.Application application = new excel.Application();
            excel.Workbook workbook = application.Workbooks.Add();
            excel.Worksheet worksheet = (excel.Worksheet)workbook.ActiveSheet;

            try
            {             
                worksheet.Cells[1, 1] = "Инвентарная книга";
                excel.Range titleList = worksheet.Cells[1, 1];
                titleList.Font.Name = "Times New Roman";
                titleList.Font.Size = 16;
                titleList.Font.Bold = 2;
                titleList.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                titleList.VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 9]].Merge();

                worksheet.Cells[2, 1] = "Номер записи";
                worksheet.Cells[2, 2] = "Дата записи";
                worksheet.Cells[2, 3] = "Автор";
                worksheet.Cells[2, 4] = "Название книги";
                worksheet.Cells[2, 5] = "ISBN номер";
                worksheet.Cells[2, 6] = "Жанр";
                worksheet.Cells[2, 7] = "Год издания";
                worksheet.Cells[2, 8] = "Издательство";
                worksheet.Cells[2, 9] = "Кол-во страниц";

                worksheet.Columns[1].ColumnWidth = 9;
                worksheet.Columns[2].ColumnWidth = 12;
                worksheet.Columns[3].ColumnWidth = 29;
                worksheet.Columns[4].ColumnWidth = 18;
                worksheet.Columns[5].ColumnWidth = 18;
                worksheet.Columns[6].ColumnWidth = 20;
                worksheet.Columns[7].ColumnWidth = 12;
                worksheet.Columns[8].ColumnWidth = 13;
                worksheet.Columns[9].ColumnWidth = 10;

                for (int i = 0; i < dBTables.DTInvenoryBook.Rows.Count; i++)
                    for (int j = 0; j < dBTables.DTInvenoryBook.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 3, j + 1] = dBTables.DTInvenoryBook.Rows[i][j].ToString();

                        if (j + 1 == 5)
                            ((excel.Range)worksheet.Cells[i + 3, j + 1]).NumberFormat = "0";
                    }

                var titleColumns = (excel.Range)worksheet.Rows["2:" + (dBTables.DTInvenoryBook.Rows.Count + 2).ToString()];
                titleColumns.Font.Name = "Times New Roman";
                titleColumns.Font.Size = 12;
                titleColumns.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                titleColumns.VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                titleColumns.WrapText = true;

                var allRows = (excel.Range)worksheet.Rows["1:" + (dBTables.DTInvenoryBook.Rows.Count + 2).ToString()];
                allRows.Borders.LineStyle = excel.XlLineStyle.xlContinuous;
                allRows.Borders.ColorIndex = 0;
                allRows.Borders.TintAndShade = 0;
                allRows.Borders.Weight = excel.XlBorderWeight.xlThin;

                application.ActiveWindow.View = excel.XlWindowView.xlPageBreakPreview;

                MessageBox.Show("Документ сформирован успешно.", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                workbook.SaveAs(@"D:\Games\Инвентарная книга от " + DateTime.Now.ToString("HH.mm.ss_dd.MM.yyyy") + ".xlsx", application.DefaultSaveFormat);
                workbook.Close();
                application.Quit();
            }
        }
    }
}
