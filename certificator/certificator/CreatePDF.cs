using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mime;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Crypto.Tls;
using Sertificator;


namespace sertificator
{
    class CreatePDF
    {
        private CertificatData certificate;
        private CompanyInfo companyI;
        public CreatePDF( CertificatData certificatData, CompanyInfo companyInfo)
        {

            certificate = certificatData;
            companyI = companyInfo;

        }

        public void BorderCell(PdfPCell cell)
        {
            cell.BorderWidthBottom = 0f;
            cell.BorderWidthLeft = 0f;
            cell.BorderWidthTop = 0f;
            cell.BorderWidthRight = 0f;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
        }

        public void Create()
        {
            string company = companyI.Name;
            int number = companyI.SertificatNumber;
            string clientName = certificate.ClientFIO;
            DateTime date = certificate.DateOrder;
            string adminName = companyI.Manager;
            string textService = "ServiceDescription"; //about proc
            //companyI.ReadTextService(certificate.SertificatNumber, out ServiceDescription);
            string filePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string imagePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string font = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            const string str1 = "Сертификат";
            string str2 = "#" + number;
            string addadm = "Администратор: "+adminName;
            string numString = number.ToString();
            string dateString = date.ToShortDateString();
            using (FileStream fs = new FileStream(filePath + @"/results/" + numString +"_ww_"+dateString+".pdf", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Rectangle pagesize = new Rectangle(PageSize.A5.Rotate()); //size of document
                Document doc = new Document(pagesize, 0f, 0f, 0f, 0f);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();
                Image jpg = Image.GetInstance(imagePath + @"/resourses/image.jpg");
                jpg.ScaleToFit(610f, 420f); // size of image
                jpg.Alignment = Image.UNDERLYING; //image like background
                doc.Add(jpg);
                PdfPTable table = new PdfPTable(1);
                //first cell - Name of company
                FontSelector selector = new FontSelector();
                Font f = FontFactory.GetFont(font+@"/resourses/constantine.ttf", BaseFont.IDENTITY_H, true);
                f.SetColor(255, 250, 250);
                selector.AddFont(f);
                var ph = selector.Process(company);
                Paragraph companyPh = new Paragraph(ph);
                PdfPCell cell = new PdfPCell(new Phrase(companyPh));
                cell.FixedHeight = 30.0f;  // Give rows some height
                BorderCell(cell);
                table.AddCell(cell);
                //second cell - Const certificate title
                FontSelector selector1 = new FontSelector();
                Font f1 = FontFactory.GetFont(font+@"/resourses/constantine.ttf", BaseFont.IDENTITY_H, true, 39);
                f1.SetColor(255, 250, 250);
                selector1.AddFont(f1);
                var ph1 = selector1.Process(str1);
                Paragraph title = new Paragraph(ph1);
                PdfPCell cell1 = new PdfPCell(new Phrase(title));
                cell1.FixedHeight = 45.0f;
                BorderCell(cell1);
                table.AddCell(cell1);
                //third cell - Certificate number
                FontSelector selector2 = new FontSelector();
                Font f2 = FontFactory.GetFont(font+@"/resourses/constantine.ttf", BaseFont.IDENTITY_H, true, 12);
                f2.SetColor(255, 228, 196);
                selector2.AddFont(f2);
                Phrase ph2 = selector2.Process(str2);
                Paragraph num = new Paragraph(ph2);
                PdfPCell cell2 = new PdfPCell(new Phrase(num));
                cell2.FixedHeight = 20.0f;
                BorderCell(cell2);
                table.AddCell(cell2);
                //4 cell - Title massage
                FontSelector selector3 = new FontSelector();
                Font f3 = FontFactory.GetFont(font+@"/resourses/constantine.ttf", BaseFont.IDENTITY_H, true, 20);
                f3.SetColor(255, 228, 196);
                selector3.AddFont(f3);
                Phrase ph3 = selector3.Process(textService);
                Paragraph usluga = new Paragraph(ph3);
                PdfPCell cell3 = new PdfPCell(new Phrase(usluga));
                cell3.FixedHeight = 45.0f;
                BorderCell(cell3);
                table.AddCell(cell3);
                //5 cell - Description of massage
                FontSelector selector4 = new FontSelector();
                Font f4 = FontFactory.GetFont(font+@"/resourses/constantine.ttf", BaseFont.IDENTITY_H, true, 9);
                selector4.AddFont(f4);
                Phrase ph4 = selector4.Process(textService);
                Paragraph about = new Paragraph(ph4);
                PdfPCell cell4 = new PdfPCell(new Phrase(about));
                cell4.FixedHeight = 40.0f;
                BorderCell(cell4);
                table.AddCell(cell4);
                //6 cell - Name of client 
                FontSelector selector5 = new FontSelector();
                Font f5 = FontFactory.GetFont(font+@"/resourses/constantine.ttf", BaseFont.IDENTITY_H, true, 30);
                selector5.AddFont(f5);
                Phrase ph5 = selector5.Process(clientName);
                Paragraph name = new Paragraph(ph5);
                PdfPCell cell5 = new PdfPCell(new Phrase(name));
                cell5.FixedHeight = 100.0f;
                BorderCell(cell5);
                table.AddCell(cell5);
                //7 cell - Name of admin 
                FontSelector selector6 = new FontSelector();
                Font f6 = FontFactory.GetFont(font+@"/resourses/constantine.ttf", BaseFont.IDENTITY_H, true, 10);
                f6.SetColor(30, 144, 255);
                selector6.AddFont(f6);
                Phrase ph6 = selector6.Process(addadm);
                Paragraph admin = new Paragraph(ph6);
                PdfPCell cell6 = new PdfPCell(new Phrase(admin));
                cell6.FixedHeight = 115.0f;
                BorderCell(cell6);
                table.AddCell(cell6);
                doc.Add(table);
                doc.Close();
            }
        }
    }
}