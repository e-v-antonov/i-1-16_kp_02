using System;
using System.Data;
using System.IO;
using System.Threading;
using Xceed.Words.NET;

namespace Library
{
    class RegistrationCardWord
    {
        string fileName;
        string oldFileName;

        public void CreateRegistrationCard(string registrationNumber, string dateRegistration, string surname, string name, string patronymic, string birthday, string passportSeries,
            string passportNumber, string whoGivePassport, string whenGivePassport, string town, string street, string building, 
            string apartment, string mobilePhone, string homePhone, string email, bool pdf)
        {
            try
            {
                fileName = @"D:\Games\Регистрационная карточка " + surname + " " + name + " " + patronymic + " от " + DateTime.Now.ToString("HH.mm.ss_dd.MM.yyyy") + ".docx";

                using (DocX document = DocX.Create(fileName))   //формирование документа в формате docx
                {
                    document.MarginTop = 56.6f;
                    document.MarginLeft = 56.6f;
                    document.MarginRight = 28.3f;
                    document.MarginBottom = 56.6f;

                    var title = document.InsertParagraph();
                    var data = document.InsertParagraph();
                    var text = document.InsertParagraph();
                    var placeOfSignature = document.InsertParagraph();
                    var instruction = document.InsertParagraph();

                    title.Append("Регистрационная карточка читателя \n библиотеки №127").Font(new Font("Times New Roman")).FontSize(16).Bold().SetLineSpacing(LineSpacingType.Line, 1.5f);
                    title.Alignment = Alignment.center;

                    data.Append("Регистрационный номер: " + registrationNumber + "\nДата заполнения: " + dateRegistration + "\nФамилия: " + surname + "\nИмя: " + name + "\nОтчество: " + patronymic + "\nДата рождения: " + birthday + "\nСерия и номер паспорта: " + passportSeries + " " + passportNumber + "\nКем выдан: " + whoGivePassport + "\nКогда выдан: " + whenGivePassport + "\nАдрес проживания: " + town + ", " + street + ", дом " + building + ", квартира" + apartment + "\nДомашний телефон: " + homePhone + "\nМобильный телефон: " + mobilePhone + "\nАдрес электронной почты: " + email + "\n")
                        .Font(new Font("Times New Roman")).FontSize(14).SetLineSpacing(LineSpacingType.Line, 1.5f);
                    data.Alignment = Alignment.left;

                    text.Append("\tПодтверждаю, что я ознакомлен и полностью согласен с условиями оказания мне библиотечных услуг библиотекой №127 изложенными в «Правилах пользования библиотекой №127», я согласен с тем, что библиотека может отказать мне в обслуживании в случае их нарушения. Также даю свое согласие на обработку моих персональных данных, указанных в настоящей регистрационной карточке.\n\tДанное согласие действует до моего прямого отказа от пользования услугами библиотеки, выраженного мною лично в устной или письменной форме.")
                        .Font(new Font("Times New Roman")).FontSize(14).SetLineSpacing(LineSpacingType.Line, 1.5f);
                    text.Alignment = Alignment.both;

                    placeOfSignature.Append("____________ / ____________").Font(new Font("Times New Roman")).FontSize(14).SetLineSpacing(LineSpacingType.Line, 1f);
                    placeOfSignature.Alignment = Alignment.right;

                    instruction.Append("\t\t\t\t\t\t\t\t\t\tПодпись                 Расшифровка").Font(new Font("Times New Roman")).FontSize(10).Bold();

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
