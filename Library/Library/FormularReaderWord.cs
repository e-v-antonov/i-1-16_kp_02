using System;
using System.IO;
using Xceed.Words.NET;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    class FormularReaderWord
    {
        private string fileName;
        private string oldFileName;

        public void CreateFormularReader(string registrationNumber, string surname, string name, string patronymic, DataTable dtFormular, bool pdf)
        {
            try
            {
                if (RegistryData.DirPath == "")
                {
                    RegistryData.DirPath = "C:\\Users\\" + SystemInformation.UserName + "\\Documents\\Отчёты";
                    if (!Directory.Exists(RegistryData.DirPath))
                        Directory.CreateDirectory(RegistryData.DirPath);
                }

                fileName = RegistryData.DirPath + "\\Формуляр " + surname + " " + name + " " + patronymic + " от " + DateTime.Now.ToString("HH.mm.ss_dd.MM.yyyy") + ".docx";

                using (DocX document = DocX.Create(fileName))   //формирование документа в формате docx
                {
                    document.PageLayout.Orientation = Xceed.Words.NET.Orientation.Landscape;
                    document.MarginTop = 28.3f;
                    document.MarginLeft = 56.6f;
                    document.MarginRight = 33.96f;
                    document.MarginBottom = 14.15f;

                    var title = document.InsertParagraph();
                    var text = document.InsertParagraph();
                    var table = document.AddTable(dtFormular.Rows.Count + 1, 8);
                    table.Design = TableDesign.TableGrid;
                    var mainTable = document.InsertTable(table);

                    title.Append("Формуляр читателя").Font(new Font("Times New Roman")).FontSize(16).Bold().SetLineSpacing(LineSpacingType.Line, 1.5f);
                    title.Alignment = Alignment.center;

                    text.Append("Фамилия: " + surname + "\nИмя: " + name + "\nОтчество: " + patronymic + "\nРегистрационный номер: " + registrationNumber).Font(new Font("Times New Roman")).FontSize(14).SetLineSpacing(LineSpacingType.Line, 1.5f);
                    text.Alignment = Alignment.left;

                    mainTable.Rows[0].Cells[0].Paragraphs[0].Append("Дата выдачи книги");
                    mainTable.Rows[0].Cells[1].Paragraphs[0].Append("Дата возврата книги");
                    mainTable.Rows[0].Cells[2].Paragraphs[0].Append("Кол-во дней выдачи");
                    mainTable.Rows[0].Cells[3].Paragraphs[0].Append("Инв. номер книги");
                    mainTable.Rows[0].Cells[4].Paragraphs[0].Append("Название книги");
                    mainTable.Rows[0].Cells[5].Paragraphs[0].Append("Автор книги");
                    mainTable.Rows[0].Cells[6].Paragraphs[0].Append("Подпись читателя");
                    mainTable.Rows[0].Cells[7].Paragraphs[0].Append("Подпись библиотекаря");

                    for (int i = 0; i < dtFormular.Rows.Count; i++)
                        for (int j = 0; j < dtFormular.Columns.Count; j++)
                        {
                            mainTable.Rows[i + 1].Cells[j].Paragraphs[0].Append(dtFormular.Rows[i][j].ToString());
                        }

                    for (int i = 0; i < mainTable.RowCount; i++)
                        for (int j = 0; j < mainTable.ColumnCount; j++)
                        {
                            var cell = mainTable.Rows[i].Cells[j];
                            cell.Paragraphs[0].Font(new Font("Times New Roman")).FontSize(10).SetLineSpacing(LineSpacingType.Line, 1);
                            cell.VerticalAlignment = VerticalAlignment.Center;
                            cell.Paragraphs[0].Alignment = Alignment.center;
                        }

                    document.Save();

                    if (pdf == true)    //формирование документа pdf
                    {
                        Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
                        var wordDocument = appWord.Documents.Open(fileName);
                        oldFileName = fileName;
                        fileName = fileName.Remove(fileName.Length - 4);
                        wordDocument.ExportAsFixedFormat(fileName + "pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                        wordDocument.Close();
                        appWord.Quit();
                        FileInfo fileWord = new FileInfo(oldFileName);
                        fileWord.Delete();
                    }
                }
            }
            catch (Exception ex)
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
        }
    }
}
