namespace KeturioliktaUzduotis_MazejanciosReiksmesEiluteje
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Naudokite funkcija new Random().
                        // Sugeneruokite 6 kintamuosius su atsitiktinem reikšmėm nuo 1000 iki 9999.
                        // Atspausdinkite reikšmes viename stringe, išrūšiuotas nuo didžiausios iki mažiausios, atskirtas tarpais.
                        // Naudoti ciklų ir masyvų NEGALIMA.

                        Random rnd = new Random();
                        int x1 = rnd.Next(1000, 9999);
                        int x2 = rnd.Next(1000, 9999);
                        int x3 = rnd.Next(1000, 9999);
                        int x4 = rnd.Next(1000, 9999);
                        int x5 = rnd.Next(1000, 9999);
                        int x6 = rnd.Next(1000, 9999);
                        int y1, y2, y3, y4, y5, y6;

                        Console.WriteLine($"{x1}, {x2}, {x3}, {x4}, {x5}, {x6}");
                        // max -> min
                        if (x1 >= x2)
                        {
                                y1 = x1;
                                y2 = x2;
                        }
                        else
                        {
                                y1 = x2;
                                y2 = x1;
                        }

                        if (x3 <= y1 && x3 <= y2)
                        {
                                y3 = x3;

                        }
                        else if (x3 <= y1 && x3 >= y2)
                        {
                                y3 = y2;
                                y2 = x3;
                        }
                        else
                        {
                                y3 = y2;
                                y2 = y1;
                                y1 = x3;
                        }
                        

                        if (x4 <= y1 && x4 <= y2 && x4 <= y3)
                        {
                                y4 = x4;
                        }
                        else if (x4 >= y3 && x4 <= y2)
                        {
                                y4 = y3;
                                y3 = x4;
                        }
                        else if (x4 >= y2 && x4 <= y1)
                        {
                                y4 = y3;
                                y3 = y2;
                                y2 = x4;
                        }
                        else
                        {
                                y4 = y3;
                                y3 = y2;
                                y2 = y1;
                                y1 = x4;
                        }

                        if( x5 <= y1 && x5 <= y2 && x5 <= y3 && x5 <= y4)
                        {
                                y5 = x5;
                        }
                        else if (x5 >= y4 && x5 <= y3)
                        {
                                y5 = y4;
                                y4 = x5;
                        }
                        else if (x5 >= y3 && x5 <= y2)
                        {
                                y5 = y4;
                                y4 = y3;
                                y3 = x5;

                        }
                        else if (x5 >= y2 && x5 <= y1)
                        {
                                y5 = y4;
                                y4 = y3;
                                y3 = y2;
                                y2 = x5;

                        }
                        else
                        {
                                y5 = y4;
                                y4 = y3;
                                y3 = y2;
                                y2 = y1;
                                y1 = x5;
                        }

                        if (x6 <= y1 && x6 <= y2 && x6 <= y3 && x6 <= y4 && x6 <= y5)
                        {
                                y6 = x6;
                        }
                        else if (x6 >= y5 && x6 <= y4)
                        {
                                y6 = y5;
                                y5 = x6;
                        }
                        else if (x6 >= y4 && x6 <= y3)
                        {
                                y6 = y5;
                                y5 = y4;
                                y4 = x6;

                        }
                        else if (x6 >= y3 && x6 <= y2)
                        {
                                y6 = y5;
                                y5 = y4;
                                y4 = y3;
                                y3 = x6;

                        }
                        else if (x6 >= y2 && x6 <= y1)
                        {
                                y6 = y5;
                                y5 = y4;
                                y4 = y3;
                                y3 = y2;
                                y2 = x6;
                        }
                        else
                        {
                                y6 = y5;
                                y5 = y4;
                                y4 = y3;
                                y3 = y2;
                                y2 = y1;
                                y1 = x6;
                        }

                        Console.WriteLine($"{y1}, {y2}, {y3}, {y4}, {y5}, {y6}");
                }
        }
}