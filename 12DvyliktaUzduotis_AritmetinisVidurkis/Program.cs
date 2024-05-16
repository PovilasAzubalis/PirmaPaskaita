using System;

namespace DvyliktaUzduotis_AritmetinisVidurkis
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        Random rnd = new Random();
                        int a1 = rnd.Next(0, 100);
                        int a2 = rnd.Next(0, 100);
                        int a3 = rnd.Next(90, 100);
                        int daliklis = 3;
                        int vidurkis = (a1 + a2 + a3) / daliklis;

                        Console.WriteLine($"a1: {a1}, a2: {a2}, a3: {a3}\n");
                        Console.WriteLine($"Aritmetinis reiksmiu vidurkis: {vidurkis}");
                        Console.WriteLine();

                        if (a1 < 10 || a1 > 90) 
                        {
                                a1 = 0;
                                daliklis--;
                        }

                        if (a2 < 10 || a2 > 90)
                        {
                                a2 = 0;
                                daliklis--;
                        }

                        if (a3 < 10 || a3 > 90);
                        {
                                a3 = 0;
                                daliklis--;
                        }
                        vidurkis = (a1 + a2 + a3) / daliklis;

                        Console.WriteLine($"Aritmetinis reiksmiu vidurkis be 10% ekstremumu: {vidurkis}");
                }
        }
}
