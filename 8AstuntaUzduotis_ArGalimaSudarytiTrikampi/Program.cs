﻿namespace AstuntaUzduotis_ArGalimaSudarytiTrikampi
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Įvedami skaičiai - a, b, c –kraštinių ilgiai, trys kintamieji (naudojame int)
                        // (naudokite new Random() funkcija nuo 1 iki 10). Parašykite C# programą, kuri nustatytų,
                        // ar galima sudaryti trikampį ir atsakymą atspausdintų.

                        Random rnd = new Random();
                        int z1 = rnd.Next(1, 10);
                        int z2 = rnd.Next(1, 10);
                        int z3 = rnd.Next(1, 10);
                        Console.WriteLine($"z1: {z1} z2: {z2} z3: {z3}");
                        if (z1 + z2 > z3 && z1 + z3 > z2 && z2 + z3 > z1 && z1 + z2 + z3 != z1)
                        {
                                Console.WriteLine("Trikampi sudaryti galima.");
                        }
                        else
                        {
                                Console.WriteLine("Trikampio sudaryti negalima.");
                        }
                }
        }
}