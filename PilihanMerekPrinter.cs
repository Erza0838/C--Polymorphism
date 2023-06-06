using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_Printer
{
    internal class MerekPrinterInput
    {
        public string[] MerekPrinter = { "Epson", "Canon", "LasetJet" };
        public string inputAngkaPilihan;

        public void PilihanPrinter()
        {
            Console.WriteLine("Pilih Printer");
            inputAngkaPilihan = Console.ReadLine();

            for(int angka = 0; angka < MerekPrinter.Length; angka++)
            {
                Console.WriteLine(angka + MerekPrinter[angka]);
            }
        }
    }

    internal class EpsonPrinter : MerekPrinterInput
    {
        public void TampilkanPesanEpsonPrinter()
        {
            Console.WriteLine("Epson display dimention : 10 * 13");
        }
    }

    internal class CanonPrinter : MerekPrinterInput
    {
        public void TampilkanPesanCanonPrinter()
        {
            Console.WriteLine("Epson display dimention : 9.5 * 12");
        }
    }

    internal class LasetJetPrinter : MerekPrinterInput
    {
        public void TampilkanPesanCanonPrinter()
        {
            Console.WriteLine("Epson display dimention : 9.5 * 12");
        }
    }
}
