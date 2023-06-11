public class MerekPrinterInput
{
    public string[] MerekPrinter = { "Epson", "Canon", "LasetJet" };
    public string inputAngkaPilihan = "";
    
    public virtual void PilihanPrinter()
    {   
        for(int angka = 0; angka < 3; angka++)
        {
            Console.WriteLine(angka + ". " + MerekPrinter[angka]);
        }
    }
}
public class OutputPilihanPrinter : MerekPrinterInput
{   
    public override void PilihanPrinter()
    {   
        Console.WriteLine("Pilih Printer [0..2] : ");
        inputAngkaPilihan = Console.ReadLine();

        switch(inputAngkaPilihan)
        {   
            case "0" : Console.WriteLine("Epson display dimention : 10 * 13");
            break;
            case "1" : Console.WriteLine("Canon display dimention : 9.5 * 12");
            break;
            case "2" : Console.WriteLine("Canon display dimention : 9.5 * 13");
            break;
        }
    }   
}