using System;
using System.Data;
using System.Threading;
using word = Microsoft.Office.Interop.Word;

namespace Library
{
    class RegistrationCardWord
    {
        private word.Paragraphs listParagraph;
        private word.Paragraph wordparagraph;

        public void CreateDoc()
        {
            //Thread thread = new Thread(CreateRegistrationCardWord);
            //thread.Start();
            CreateRegistrationCardWord();
        }

        private void CreateRegistrationCardWord()
        {
            word.Application application = new word.Application();
            application.Visible = false;

            object missing = Type.Missing;
            word.Document document = application.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            //word.Range range = document.Range(0, 0);
            //range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;

            string fileName = @"D:\Games\Пример.docx";

            document.Sections.PageSetup.LeftMargin = application.CentimetersToPoints(2);
            document.Sections.PageSetup.RightMargin = application.CentimetersToPoints(1);
            document.Sections.PageSetup.TopMargin = application.CentimetersToPoints(2);
            document.Sections.PageSetup.BottomMargin = application.CentimetersToPoints(2);                     

            word.Paragraph title = document.Paragraphs.Add();
            title.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
            title.Range.Font.Name = "Times New Roman";
            title.Range.Font.Size = 16;
            title.Range.Bold = 2;
            title.Range.ParagraphFormat.SpaceAfter = 0;
            title.Range.ParagraphFormat.SpaceBefore = 0;
            title.Range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpace1pt5;
            title.Range.Text = "Регистрационная карточка читателя\nбиблиотеки №127";

            //word.Range range = document.Range(0, 40);
            //range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;                  

            word.Paragraph text = document.Paragraphs.Add();
            text.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
            text.Range.Font.Name = "Times New Roman";
            text.Range.Font.Size = 14;
            text.Range.Bold = 0;
            text.Range.ParagraphFormat.SpaceAfter = 0;
            text.Range.ParagraphFormat.SpaceBefore = 0;
            text.Range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpace1pt5;
            text.Range.Text = "Регистрационный номер:\nДата заполнения:\nФамилия:\nИмя:\nОтчество:\nДата рождения:\nСерия и номер паспорта:\nКем выдан:\nКогда выдан:\nАдрес проживания:\nДомашний телефон:\nМобильный телефон:\nАдрес электронной почты:\n";

            document.Paragraphs.Add();
            document.Paragraphs.Add();

            word.Paragraph agreement = document.Paragraphs.Add();
            agreement.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphJustify;
            agreement.Range.Font.Name = "Times New Roman";
            agreement.Range.Font.Size = 14;
            agreement.Range.ParagraphFormat.SpaceAfter = 0;
            agreement.Range.ParagraphFormat.SpaceBefore = 0;
            agreement.Range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpace1pt5;
            //agreement.Range.ParagraphFormat.LeftIndent = application.CentimetersToPoints(Convert.ToSingle(1.5));
            agreement.Range.Text = "    Подтверждаю, что я ознакомлен и полностью согласен с условиями оказания мне библиотечных услуг библиотекой №127 изложенными в «Правилах пользования библиотекой №127», я согласен с тем, что библиотека может отказать мне в обслуживании в случае их нарушения. Также даю свое согласие на обработку моих персональных данных, указанных в настоящей регистрационной карточке.";

            document.Paragraphs.Add();
            document.Paragraphs.Add();

            word.Paragraph agreement1 = document.Paragraphs.Add();
            agreement1.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphJustify;
            agreement1.Range.Font.Name = "Times New Roman";
            agreement1.Range.Font.Size = 14;
            agreement1.Range.ParagraphFormat.SpaceAfter = 0;
            agreement1.Range.ParagraphFormat.SpaceBefore = 0;
            agreement1.Range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpace1pt5;
            agreement1.Range.Text = "    Данное согласие действует до моего прямого отказа от пользования услугами библиотеки, выраженного мною лично в устной или письменной форме.";


            document.Paragraphs.Add();
            document.Paragraphs.Add();


            word.Paragraph signature = document.Paragraphs.Add();
            
            signature.Range.Font.Name = "Times New Roman";
            signature.Range.Font.Size = 14;
            signature.Range.ParagraphFormat.SpaceAfter = 0;
            signature.Range.ParagraphFormat.SpaceBefore = 0;
            signature.Range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpaceSingle;
            signature.Range.Text = "____________ / ____________";
            signature.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphRight;

            document.Paragraphs.Add();
            document.Paragraphs.Add();


            word.Paragraph decryptione = document.Paragraphs.Add();
            decryptione.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
            decryptione.Range.Font.Name = "Times New Roman";
            decryptione.Range.Font.Size = 10;
            decryptione.Range.Font.Bold = 2;
            decryptione.Range.ParagraphFormat.SpaceAfter = 0;
            decryptione.Range.ParagraphFormat.SpaceBefore = 0;
            decryptione.Range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpaceSingle;
            decryptione.Range.Text = "										Подпись                 Расшифровка";

            document.SaveAs2(fileName, word.WdSaveFormat.wdFormatDocumentDefault, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            object save_changes = false;
            document.Close(ref save_changes, ref missing, ref missing);
            application.Quit(ref save_changes, ref missing, ref missing);
        }
    }
}
