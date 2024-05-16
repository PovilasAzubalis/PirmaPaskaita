using System;

namespace PenktaUzduotis_Prisistatymas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string Vardas = "Povilas";
            string Pavarde = "Azubalis";
            int GimimoMetai = 1997;
            int EinamiejiMetai = 2024;
            int amzius = EinamiejiMetai - GimimoMetai;
            Console.WriteLine($"Aš esu {Vardas} {Pavarde}. Man yra {amzius} metai(ų).\n");

        }
    }
}