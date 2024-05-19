namespace PenkiolyktaUzduotis_SavaitesDienosPavadinimas
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite programą, kuri paprašytų vartotojo įvesti savaitės dienos numerį (1 iki 7)
                        // ir pagal tai atspausdintų dienos pavadinimą naudojant switch sakinį.

                        Console.Write("Prasome ivesti savaites dienos numeri (1 - 7 ): ");
                        int x = int.Parse(Console.ReadLine());

                        switch (x)
                        {
                                case 1:
                                        Console.WriteLine("Pirmadienis");
                                        break;
                                case 2:
                                        Console.WriteLine("Antradienis");
                                        break;
                                case 3:
                                        Console.WriteLine("Treciadienis");
                                        break;
                                case 4:
                                        Console.WriteLine("Ketvirtadienis");
                                        break;
                                case 5:
                                        Console.WriteLine("Penktadienis");
                                        break;
                                case 6:
                                        Console.WriteLine("Sestadienis");
                                        break;
                                case 7:
                                        Console.WriteLine("Sekmadienis");
                                        break;

                        }
                }
        }
}