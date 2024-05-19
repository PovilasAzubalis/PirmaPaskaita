namespace SesioliktaUzduotis_IvestuDuomenuAtpazinimas
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite programą, kuri atskirtų kokio tipo t.y (int, string) (tik šių 2) tipo reikšmė buvo įvesta.
                        // Jeigu tai int kintamasis tai jį reikia padauginti iš 11 ir atvaizduoti ekrane.
                        // Jeigu tai string tipo kintamasis reikia prieš jį pridėti # ir po jo pridėti # ir atvaizduoti naują reikšmę ekrane

                        Console.Write("Iveskite teksta arba sveikuosius skaicius: ");
                        string ivestis = Console.ReadLine();
                        bool integerCheck = int.TryParse(ivestis, out int skaicius);

                        switch (integerCheck)
                        {
                                case true:
                                        Console.WriteLine($"{skaicius * 11}");
                                        break;
                                case false:
                                        Console.WriteLine($"#{ivestis}#");
                                        break;
                        }
                }
        }
}