namespace PirmaUzduotis_SveikinimoPrograma
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite programą, kuri paprašytų vartotojo įvesti savo vardą
                        // ir po to pasveikintų jį išvedant tekstą į konsolę.
                        Console.WriteLine("Įveskite savo vardą.");
                        string vardas = Console.ReadLine();

                        Console.WriteLine($"Labas, {vardas}");


                }
        }
}
