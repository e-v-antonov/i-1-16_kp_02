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

            string fileName = @"D:\Games\Пример.docx";

                document.Sections.PageSetup.LeftMargin = application.CentimetersToPoints(2);
                document.Sections.PageSetup.RightMargin = application.CentimetersToPoints(1);
                document.Sections.PageSetup.TopMargin = application.CentimetersToPoints(2);
                document.Sections.PageSetup.BottomMargin = application.CentimetersToPoints(2);
                document.Sections.PageSetup.VerticalAlignment = word.WdVerticalAlignment.wdAlignVerticalTop;

            word.Paragraph para = document.Paragraphs.Add(ref missing);
           
            
            //para.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
            para.Range.Font.Name = "Times New Roman";
            para.Range.Bold = 2;
            para.Range.Font.Size = 16;
            para.Range.ParagraphFormat.SpaceAfter = 0;
            para.Range.ParagraphFormat.SpaceBefore = 0;
            para.Range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpace1pt5;
            para.Range.Text = "Регистрационная карточка читателя";
          
            para.Range.InsertParagraphAfter();
            para.Range.Text = "библиотеки №127";

            para.Range.InsertParagraphAfter();
            //para.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
            para.Range.Font.Name = "Times New Roman";
            para.Range.Font.Size = 14;
            para.Range.ParagraphFormat.SpaceAfter = 0;
            para.Range.ParagraphFormat.SpaceBefore = 0;
            para.Range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpace1pt5;
            para.Range.Text = "Регистрационный номер:\nДата заполнения:\nФамилия:\nИмя:\nОтчество:\nДата рождения:\nСерия и номер паспорта:\nКем выдан:\nКогда выдан:\nАдрес проживания:\nДомашний телефон:\nМобильный телефон:\nАдрес электронной почты:\n";
            

            //object oMissing = System.Reflection.Missing.Value;
            //document.Paragraphs.Add(ref oMissing);
            //document.Paragraphs.Add(ref oMissing);
            //document.Paragraphs.Add(ref oMissing);
            //document.Paragraphs.Add(ref oMissing);
            //document.Paragraphs.Add(ref oMissing);
            //document.Paragraphs.Add(ref oMissing);
            //document.Paragraphs.Add(ref oMissing);



            //listParagraph = document.Paragraphs;

            //wordparagraph = (word.Paragraph)listParagraph[1];
            //wordparagraph.Range.Text = "Регистрационная карточка читателя";
            //wordparagraph.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
            //wordparagraph.Range.Font.Name = "Times New Roman";
            //wordparagraph.Range.Bold = 2;
            //wordparagraph.Range.Font.Size = 16;
            //wordparagraph.Range.ParagraphFormat.SpaceAfter = 0;
            //wordparagraph.Range.ParagraphFormat.SpaceBefore = 0;
            //wordparagraph.Range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpace1pt5;

            //wordparagraph = (word.Paragraph)listParagraph[2];
            //wordparagraph.Range.Text = "библиотеки №127";
            //wordparagraph.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
            //wordparagraph.Range.Font.Name = "Times New Roman";
            //wordparagraph.Range.Bold = 2;
            //wordparagraph.Range.Font.Size = 16;
            //wordparagraph.Range.ParagraphFormat.SpaceAfter = 0;
            //wordparagraph.Range.ParagraphFormat.SpaceBefore = 0;
            //wordparagraph.Range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpace1pt5;

            //wordparagraph = (word.Paragraph)listParagraph[3];
            //wordparagraph.Range.Text = "Регистрационный номер:\nДата заполнения:\nФамилия:\nИмя:\nОтчество:\nДата рождения:\nСерия и номер паспорта:\nКем выдан:\nКогда выдан:\nАдрес проживания:\nДомашний телефон:\nМобильный телефон:\nАдрес электронной почты:\n";
            //wordparagraph.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
            //wordparagraph.Range.Font.Name = "Times New Roman";
            //wordparagraph.Range.Font.Size = 14;
            //wordparagraph.Range.ParagraphFormat.SpaceAfter = 0;
            //wordparagraph.Range.ParagraphFormat.SpaceBefore = 0;
            //wordparagraph.Range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpace1pt5;

            //wordparagraph = (word.Paragraph)listParagraph[4];
            //wordparagraph.Range.Text = "";
            //wordparagraph.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
            //wordparagraph.Range.Font.Name = "Times New Roman";
            //wordparagraph.Range.Font.Size = 14;
            //wordparagraph.Range.ParagraphFormat.SpaceAfter = 0;
            //wordparagraph.Range.ParagraphFormat.SpaceBefore = 0;
            //wordparagraph.Range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpace1pt5;

            //wordparagraph = (word.Paragraph)listParagraph[16];
            //wordparagraph.Range.Text = "Подтверждаю, что я ознакомлен и полностью согласен с условиями оказания мне библиотечных услуг библиотекой №127 изложенными в «Правилах пользования библиотекой №127», я согласен с тем, что библиотека может отказать мне в обслуживании в случае их нарушения. Также даю свое согласие на обработку моих персональных данных, указанных в настоящей регистрационной карточке.";
            //wordparagraph.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphJustify;
            //wordparagraph.Range.Font.Name = "Times New Roman";
            //wordparagraph.Range.Font.Size = 14;
            //wordparagraph.Range.ParagraphFormat.SpaceAfter = 0;
            //wordparagraph.Range.ParagraphFormat.SpaceBefore = 0;
            //wordparagraph.Range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpace1pt5;

            //document.SaveAs2(fileName, word.WdSaveFormat.wdFormatDocumentDefault);
            //document.Close();
            //application.Quit();

            document.SaveAs2(fileName, word.WdSaveFormat.wdFormatDocumentDefault, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            object save_changes = false;
            document.Close(ref save_changes, ref missing, ref missing);
            application.Quit(ref save_changes, ref missing, ref missing);
        }
    }
}
