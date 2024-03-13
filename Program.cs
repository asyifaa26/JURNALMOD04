// See https://aka.ms/new-console-template for more information

using modul4_1302223029;
using static modul4_1302223029.KodeBuah;

internal class Program
{
    private static void Main(string[] args)
    {
        KodeBuah kodeBuah = new KodeBuah();
        Console.WriteLine("Kode Buah Apel: " + kodeBuah.GetKodeBuah(NamaBuah.Apel));
        Console.WriteLine("Kode Buah Aprikot: " + kodeBuah.GetKodeBuah(NamaBuah.Aprikot));
        Console.WriteLine("Kode Buah Alpukat: " + kodeBuah.GetKodeBuah(NamaBuah.Alpukat));
        Console.WriteLine("Kode Buah Pisang: " + kodeBuah.GetKodeBuah(NamaBuah.Pisang));
        Console.WriteLine("Kode Buah Paprika: " + kodeBuah.GetKodeBuah(NamaBuah.Paprika));
        Console.WriteLine("Kode Buah Blackberry: " + kodeBuah.GetKodeBuah(NamaBuah.Blackberry));
        Console.WriteLine("Kode Buah Ceri: " + kodeBuah.GetKodeBuah(NamaBuah.Ceri));
        Console.WriteLine("Kode Buah Kelapa: " + kodeBuah.GetKodeBuah(NamaBuah.Kelapa));
        Console.WriteLine("Kode Buah Jagung: " + kodeBuah.GetKodeBuah(NamaBuah.Jagung));
        Console.WriteLine("Kode Buah Kurma: " + kodeBuah.GetKodeBuah(NamaBuah.Kurma));
        Console.WriteLine("Kode Buah Durian: " + kodeBuah.GetKodeBuah(NamaBuah.Durian));
        Console.WriteLine("Kode Buah Anggur: " + kodeBuah.GetKodeBuah(NamaBuah.Anggur));
        Console.WriteLine("Kode Buah Melon: " + kodeBuah.GetKodeBuah(NamaBuah.Melon));
        Console.WriteLine("Kode Buah Semangka: " + kodeBuah.GetKodeBuah(NamaBuah.Semangka));


    }
}