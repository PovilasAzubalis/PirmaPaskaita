using System;

namespace KeturioliktaUzduotis_MazejanciosReiksmesEiluteje
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        Random rnd = new Random();
                        int x1 = rnd.Next(1000, 9999);
                        int x2 = rnd.Next(1000, 9999);
                        int x3 = rnd.Next(1000, 9999);
                        int x4 = rnd.Next(1000, 9999);
                        int x5 = rnd.Next(1000, 9999);
                        int x6 = rnd.Next(1000, 9999);
                        int y1, y2, y3, y4, y5, y6;
                        
                        //didziausia verte y1
                        if (x1 >= x2 && x1 >= x3 && x1 >= x4 && x1 >= x5 && x1 >= x6)
                        {
                                y1 = x1;
                        }
                        else if (x2 >= x1 && x2 >= x3 && x2 >= x4 && x2 >= x5 && x2 >= x6)
                        {
                                y1 = x2;
                        }
                        else if (x3 >= x1 && x3 >= x2 && x3 >= x4 && x3 >= x5 && x3 >= x6)
                        {
                                y1 = x3;
                        }
                        else if (x4 >= x1 && x4 >= x2 && x4 >= x3 && x4 >= x5 && x4 >= x6)
                        {
                                y1 = x4;
                        }
                        else if (x5 >= x1 && x5 >= x2 && x5 >= x3 && x5 >= x4 && x5 >= x6)
                        {
                                y1 = x5;
                        }
                        else if (x6 >= x1 && x6 >= x2 && x6 >= x3 && x6 >= x4 && x6 >= x5)
                        {
                                y1 = x6;
                        }

                        // didziausios vertes naikinimas
                        if (y1 - x1 = 0) x1 = 0;
                        if (y1 - x2 = 0) x2 = 0;
                        if (y1 - x3 = 0) x3 = 0;
                        if (y1 - x4 = 0) x4 = 0;
                        if (y1 - x5 = 0) x5 = 0;
                        if (y1 - x6 = 0) x6 = 0;
                }
        }
}