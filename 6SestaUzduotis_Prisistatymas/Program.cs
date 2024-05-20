namespace SestaUzduotis_TeigiamasDviejuSkaiciuVidurkis
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite du kintamuosius ir naudodamiesi funkcija new Random() jiems priskirkite atsitiktines reikšmes
                        // nuo 0 iki 4. Didesnę reikšmę padalinkite iš mažesnės. Atspausdinkite rezultatą jį suapvalinę
                        // iki 2 skaičių po kablelio.

                        Random rnd = new Random();
                        int x1 = rnd.Next(0, 4);
                        int x2 = rnd.Next(0, 4);

                        if (x1 - x2 >= 0 && x2 != 0)
                        {
                                double dalmuo = x1 / x2;
                                dalmuo = Math.Round(dalmuo, 2);
                                Console.WriteLine($"X1: {x1}, X2: {x2}, dalmuo = {dalmuo}");
                        }
                        else if (x2 - x1 >= 0 && x1 != 0)
                        {
                                double dalmuo = x2 / x1;
                                dalmuo = Math.Round(dalmuo, 2);
                                Console.WriteLine($"X1: {x1}, X2: {x2}, dalmuo = {dalmuo}");
                        }
                        else
                        {
                                Console.WriteLine("Matematinis veiksmas negalimas: DALYBA IS NULIO!\n");
                        }
                }
        }
}