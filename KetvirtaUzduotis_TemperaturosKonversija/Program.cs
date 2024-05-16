using System;

namespace KetvirtaUzduotis_TemperaturosKonversija
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite temperaturos rodmenis Farenheito skaleje:");
            double temperaturaF = double.Parse(Console.ReadLine());

            temperaturaF = Math.Round((temperaturaF - 32) * 5 / 9,1);
            Console.WriteLine($"\nCelsijaus skaleje turesime {temperaturaF} laipsnius.");
        }
    }
}
