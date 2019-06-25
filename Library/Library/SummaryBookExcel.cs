using System;
using System.IO;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;

namespace Library
{
    class SummaryBookExcel
    {
        DBTables dBTables = new DBTables();

        public void SummaryBookFill()    //заполнение data table
        {
            dBTables.DTSummaryBookfill();
            CreateSummaryBook();
        }

        private void CreateSummaryBook()    //создание документа
        {
            excel.Application application = new excel.Application();
            excel.Workbook workbook = application.Workbooks.Add();
            excel.Worksheet worksheet = (excel.Worksheet)workbook.ActiveSheet;

            try
            {
                worksheet.Cells[1, 1] = "Книга суммарного учета основного фонда";
                excel.Range titleList = worksheet.Cells[1, 1];
                titleList.Font.Name = "Times New Roman";
                titleList.Font.Size = 16;
                titleList.Font.Bold = 2;
                titleList.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                titleList.VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 12]].Merge();

                worksheet.Cells[2, 1] = "Номер записи";
                worksheet.Cells[2, 2] = "Дата записи";
                worksheet.Cells[2, 3] = "Инвентарный номер";
                worksheet.Cells[2, 4] = "Название книги";
                worksheet.Cells[2, 5] = "Автор";
                worksheet.Cells[2, 6] = "Жанр";
                worksheet.Cells[2, 7] = "Издательство";
                worksheet.Cells[2, 8] = "Год издания";
                worksheet.Cells[2, 9] = "Кол-во страниц";
                worksheet.Cells[2, 10] = "Кол-во экземпляров";
                worksheet.Cells[2, 11] = "Стоимость экземпляра книги, руб.";
                worksheet.Cells[2, 12] = "Сумма стоимости книг, руб.";

                worksheet.Columns[1].ColumnWidth = 9;
                worksheet.Columns[2].ColumnWidth = 12;
                worksheet.Columns[3].ColumnWidth = 15;
                worksheet.Columns[4].ColumnWidth = 18;
                worksheet.Columns[5].ColumnWidth = 29;
                worksheet.Columns[6].ColumnWidth = 17;
                worksheet.Columns[7].ColumnWidth = 14;
                worksheet.Columns[8].ColumnWidth = 10;
                worksheet.Columns[9].ColumnWidth = 8;
                worksheet.Columns[10].ColumnWidth = 12;
                worksheet.Columns[11].ColumnWidth = 12;
                worksheet.Columns[12].ColumnWidth = 12;

                for (int i = 0; i < dBTables.DTSummaryBook.Rows.Count; i++)
                {
                    worksheet.Cells[i + 3, 1] = i.ToString();

                    for (int j = 0; j < dBTables.DTSummaryBook.Columns.Count; j++)
                        worksheet.Cells[i + 3, j + 2] = dBTables.DTSummaryBook.Rows[i][j].ToString();
                }

                var titleColumns = (excel.Range)worksheet.Rows["2:" + (dBTables.DTSummaryBook.Rows.Count + 2).ToString()];
                titleColumns.Font.Name = "Times New Roman";
                titleColumns.Font.Size = 12;
                titleColumns.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                titleColumns.VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                titleColumns.WrapText = true;

                var allRows = (excel.Range)worksheet.Rows["1:" + (dBTables.DTSummaryBook.Rows.Count + 2).ToString()];
                allRows.Borders.LineStyle = excel.XlLineStyle.xlContinuous;
                allRows.Borders.ColorIndex = 0;
                allRows.Borders.TintAndShade = 0;
                allRows.Borders.Weight = excel.XlBorderWeight.xlThin;

                application.ActiveWindow.View = excel.XlWindowView.xlPageBreakPreview;

                MessageBox.Show(MessageUser.DocumentCreateSucc, MessageUser.TitleLibrary, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                if (RegistryData.DirPath == "")
                {
                    RegistryData.DirPath = "C:\\Users\\" + SystemInformation.UserName + "\\Documents\\Отчёты";
                    if (!Directory.Exists(RegistryData.DirPath))
                        Directory.CreateDirectory(RegistryData.DirPath);
                }

                workbook.SaveAs(RegistryData.DirPath + "\\Книга суммарного учета основного фонда от " + DateTime.Now.ToString("HH.mm.ss_dd.MM.yyyy") + ".xlsx", application.DefaultSaveFormat);
                workbook.Close();
                application.Quit();
            }
        }
    }
}
