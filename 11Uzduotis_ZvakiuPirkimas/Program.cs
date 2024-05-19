namespace VienuoliktaUzduotis_ZvakiuPirkimas
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Įmonė parduoda žvakes po 1 EUR.
                        // Perkant daugiau kaip 1000 vienetų taikoma 3 % nuolaida, daugiau kaip 2000 vienetų- 4 % nuolaida.
                        // Parašykite programą, kuri skaičiuos žvakių kainą ir atspausdintų atsakymą
                        // kiek žvakių ir kokia kaina perkama. Žvakių kiekį generuokite new Random() funkcija nuo 5 iki 3000.

                        Random rnd = new Random();
                        int kiekis = rnd.Next(5, 3000);
                        int kaina = 1;

                        if (kiekis <= 1000)
                        {
                                Console.WriteLine($"{kiekis} vnt. zvakiu kainuos {kiekis * kaina} Eur");
                        }
                        else if (kiekis > 1000 && kiekis <= 2000)
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
