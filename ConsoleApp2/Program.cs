using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

class Program
{
    public static void Main()
    {
        string pdfPath = "MyPDF.pdf";
        using (PdfWriter writer = new PdfWriter(pdfPath))
        {
            using (PdfDocument pdf = new PdfDocument(writer))
            {
                Document document = new Document(pdf);
                document.Add(new Paragraph("Hello, Worldererere!"));
                document.Close();
            }
        }

        Console.WriteLine("PDF generated successfully using iText 7.");
    }
}



