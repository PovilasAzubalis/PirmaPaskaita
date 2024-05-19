namespace TreciaUzduotis_AmziausSkaiciavimas
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite programą, kuri paprašytų vartotojo įvesti savo gimimo metus
                        // ir apskaičiuotų bei atspausdintų vartotojo amžių.
                        
                        Console.WriteLine("Įveskite savo gimimo metus:");
                        int gimimometai = int.Parse(Console.ReadLine());
                        int data = DateTime.Now.Year;
                        int amzius = data - gimimometai;

                        Console.WriteLine($"\nJums yra {amzius} metai");


                }
        }
}