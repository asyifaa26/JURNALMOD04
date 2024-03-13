namespace modul4_1302223029;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class KodeBuah
{
    private Dictionary<string, string> KodePosDictionary;
    public enum NamaBuah
    {
        Apel, 
        Aprikot, 
        Alpukat, 
        Pisang, 
        Paprika, 
        Blackberry, 
        Ceri,
        Kelapa, 
        Jagung,
        Kurma, 
        Durian,
        Anggur,
        Melon,
        Semangka
    }

    public string GetKodeBuah(NamaBuah nama)
    {
        String[] kodebuah =
        {
            "A00",
            "B00",
            "C00",
            "D00",
            "E00",
            "F00",
            "H00",
            "I00",
            "J00",
            "K00",
            "L00",
            "M00",
            "N00",
            "O00"
        };

        return kodebuah[(int)nama];
    }
}