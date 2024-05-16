using System;

namespace TryliktaUzduotis_Laikrodis
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        Random rnd = new Random();
                        int valandos = rnd.Next(0, 23);
                        int minutes = rnd.Next(0, 59);
                        int sekundes = rnd.Next(0, 59);
                        int PridedamosSekundes = rnd.Next(0, 300);

                        Console.WriteLine($"{valandos.ToString("D2")}:{minutes.ToString("D2")}:{sekundes.ToString("D2")}");
                        Console.WriteLine(PridedamosSekundes);

                        PridedamosSekundes += sekundes;
                        int PridedamosMinutes = PridedamosSekundes / 60;
                        sekundes = PridedamosSekundes % 60;
                        minutes += PridedamosMinutes;
                        int PridedamosValandos = minutes / 60;
                        minutes = minutes % 60;
                        valandos += PridedamosValandos;

                        if (sekundes > 59)
                        {
                                sekundes = sekundes - 60;
                        }

                        if (minutes > 59)
                        {
                                minutes = minutes - 60;
                        }

                        if (valandos > 23)
                        {
                                valandos = valandos - 24;
                                
                        }
                       
                        Console.WriteLine($"{valandos.ToString("D2")}:{minutes.ToString("D2")}:{sekundes.ToString("D2")}");





                }
        }
}