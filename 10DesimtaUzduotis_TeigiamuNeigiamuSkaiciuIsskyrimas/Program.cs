﻿namespace
    DesimtaUzduotis_TeigiamuNeigiamuSkaiciuIsskyrimas
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Naudokite funkcija new Random(). Sukurkite ir atspausdinkite 3 skaičius nuo -10 iki 10.
                        // Skaičiai mažesni už 0 turi būti  laužtiniuose skliaustuose [], 0 -  (), didesni už 0 {}.

                        Random rnd = new Random();
                        int z1 = rnd.Next(-10, 10);
                        int z2 = rnd.Next(-10, 10);
                        int z3 = rnd.Next(-10, 10);

                        if (z1 < 0)
                        {
                                Console.WriteLine($"[{z1}]");
                        }
                        else if (z1 == 0)
                        {
                                Console.WriteLine($"({z1})");
                        }
                        else
                        {
                                Console.WriteLine($"{{{z1}}}");
                        }


                        if (z2 < 0)
                        {
                                Console.WriteLine($"[{z2}]");
                        }
                        else if (z2 == 0)
                        {
                                Console.WriteLine($"({z2})");
                        }
                        else
                        {
                                Console.WriteLine($"{{{z2}}}");
                        }

                        if (z3 < 0)
                        {
                                Console.WriteLine($"[{z3}]");
                        }
                        else if (z3 == 0)
                        {
                                Console.WriteLine($"({z3})");
                        }
                        else
                        {
                                Console.WriteLine($"{{{z3}}}");
                        }


                }
        }
}