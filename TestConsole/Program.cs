using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenXML;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PDFParser pdfParser = new PDFParser();
            pdfParser.ExtractText(@"C:\Users\unknown\Desktop\oyak.pdf",
                                  @"C:\Users\unknown\Desktop\output.txt");
            Console.ReadKey();
        }
    }
}
