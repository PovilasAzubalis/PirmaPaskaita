namespace KetvirtaUzduotis_TemperaturosKonversija
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite programą, kuri leistų vartotojui įvesti temperatūrą Farenheito skalėje
                        // ir paskaičiuotų bei atspausdintų temperatūrą Celsijaus skalėje.
                        Console.WriteLine("Iveskite temperaturos rodmenis Farenheito skaleje:");
                        double temperaturaF = double.Parse(Console.ReadLine());

                        temperaturaF = Math.Round((temperaturaF - 32) * 5 / 9, 1);
                        Console.WriteLine($"\nCelsijaus skaleje turesime {temperaturaF} laipsnius.");
                }
        }
}
