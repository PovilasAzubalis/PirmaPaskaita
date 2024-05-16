using System;

namespace VienuoliktaUzduotis_ZvakiuPirkimas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int kiekis = rnd.Next(5, 3000);
            int kaina = 1;

            if (kiekis <= 1000)
            {
                Console.WriteLine($"{kiekis} vnt. zvakiu kainuos {kiekis * kaina} Eur");
            }
        else if(kiekis > 1000 && kiekis <= 2000)
            {
                
                double a = Math.Round(kiekis * kaina * 0.97, 2);
                Console.WriteLine($"{kiekis} vnt. zvakiu kainuos {a} Eur");
            }
            else
            {
                double a = Math.Round(kiekis * kaina * 0.96, 2);
                Console.WriteLine($"{kiekis} vnt. zvakiu kainuos {a} Eur");
            }
            
        }
    }
}
