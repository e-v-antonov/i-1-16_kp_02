using System;
using System.Data;
using System.Globalization;
using System.IO;
using Xceed.Words.NET;

namespace Library
{
    class ActAdoptionBookWord
    {
        private string fileName;
        private string oldFileName;
        private int countBook = 0;
        private int totalSum = 0;

        public void CreateActAdoptionBookWord(DataTable dataTable, bool pdf)
        {
            try
            {
                fileName = @"D:\Games\Акт о приемке книг от " + DateTime.Now.ToString("HH.mm.ss_dd.MM.yyyy") + ".docx";

                using (DocX document = DocX.Create(fileName))   //формирование документа в формате docx
                {
                    document.MarginTop = 56.6f;
                    document.MarginLeft = 56.6f;
                    document.MarginRight = 28.3f;
                    document.MarginBottom = 56.6f;

                    var title = document.InsertParagraph();
                    var text = document.InsertParagraph();
                    var textList = document.InsertParagraph();
                    var placeOfSignature = document.InsertParagraph();
                    var instruction = document.InsertParagraph();
                    var titleTable = document.InsertParagraph();
                    var table = document.AddTable(dataTable.Rows.Count + 1, 5);
                    table.Design = TableDesign.TableGrid;
                    var mainTable = document.InsertTable(table);

                    title.Append("Акт о приеме книг").Font(new Font("Times New Roman")).FontSize(16).SetLineSpacing(LineSpacingType.Line, 1.5f);
                    title.Alignment = Alignment.center;

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        countBook += Convert.ToInt32(dataTable.Rows[i][2].ToString());
                        totalSum += Convert.ToInt32(dataTable.Rows[i][3].ToString());
                    }

                    text.Append("\tНастоящий акт составил Должность Фамилия Имя Отчество " + DateTime.Now.ToString("dd.MM.yyyy") + " г. для приема в библиотеку книг в количестве " + countBook + " экземпляров на общую сумму " + totalSum + " руб.")
                        .Font(new Font("Times New Roman")).FontSize(14).SetLineSpacing(LineSpacingType.Line, 1.5f);
                    text.Alignment = Alignment.both;

                    textList.Append("Список книг прилагается.").Font(new Font("Times New Roman")).FontSize(14).SetLineSpacing(LineSpacingType.Line, 1.5f);
                    text.Alignment = Alignment.both;

                    placeOfSignature.Append("____________ / ____________").Font(new Font("Times New Roman")).FontSize(14).SetLineSpacing(LineSpacingType.Line, 1f);
                    placeOfSignature.Alignment = Alignment.right;

                    instruction.Append("\t\t\t\t\t\t\t\t\t\tПодпись                 Расшифровка\n").Font(new Font("Times New Roman")).FontSize(10).Bold();

                    titleTable.Append("Список книг к акту").Font(new Font("Times New Roman")).FontSize(16).SetLineSpacing(LineSpacingType.Line, 1.5f);
                    titleTable.Alignment = Alignment.center;

                    mainTable.Rows[0].Cells[0].Paragraphs[0].Append("№ п/п");
                    mainTable.Rows[0].Cells[1].Paragraphs[0].Append("Название книги, автор");
                    mainTable.Rows[0].Cells[2].Paragraphs[0].Append("Цена экземпляра, руб.");
                    mainTable.Rows[0].Cells[3].Paragraphs[0].Append("Количество экземпляров");
                    mainTable.Rows[0].Cells[4].Paragraphs[0].Append("Сумма, руб.");

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        mainTable.Rows[i + 1].Cells[0].Paragraphs[0].Append((i + 1).ToString());
                        for (int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            mainTable.Rows[i + 1].Cells[j + 1].Paragraphs[0].Append(dataTable.Rows[i][j].ToString());
                        }
                    }

                    for (int i = 0; i < mainTable.RowCount; i++)
                        for (int j = 0; j < mainTable.ColumnCount; j++)
                        {
                            var cell = mainTable.Rows[i].Cells[j];
                            cell.Paragraphs[0].Font(new Font("Times New Roman")).FontSize(12).SetLineSpacing(LineSpacingType.Line, 1.15f);
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
