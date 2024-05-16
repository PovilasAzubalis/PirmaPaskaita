using System;

namespace SeptintaUzduotis_VidurinisKintamasis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int y1 = rnd.Next(0, 0);
            int y2 = rnd.Next(0, 25);
            int y3 = rnd.Next(0, 25);
            Console.WriteLine();
            Console.WriteLine($"y1: {y1} y2: {y2} y3: {y3}");
            if ((y1 < y2 && y2 < y3) || (y3 < y2 && y2 < y1))
            {
                Console.WriteLine($"Vidurinis kintmasis yra :{y2}");
            }
            else if ((y2 < y1 && y1 < y3) || (y3 < y1 && y1 < y2))
            {
                Console.WriteLine($"Vidurinis kintmasis yra :{y1}");
            }
            else if (y1 == y2 || y2 == y3 || y3 == y1)
                Console.WriteLine("Vidurinio kintamojo isvesti nepavyko: KINTAMUJU DUBLIKACIJA!");
            else
            {
                Console.WriteLine($"Vidurinis kintmasis yra :{y3}");
            }
        }
    }
}