namespace AntraUzduotis_AitmetinesOperacijos
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite programą, kuri leistų vartotojui įvesti du skaičius
                        // ir atspausdintų jų sumą, skirtumą, sandaugą ir dalmenį.
                        
                        Console.WriteLine("Iveskite pirmaji sveikaji skaiciu:");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Iveskite antraji sveikaji skaiciu:");
                        int num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Ivestu skaiciu suma x1 + x2 = {num1 + num2}");
                        Console.WriteLine($"Ivestu skaiciu skirtumas x1 - x2 = {num1 - num2}");
                        Console.WriteLine($"Ivestu skaiciu sandauga x1 * x2 = {num1 * num2}");
                        Console.WriteLine($"Ivestu skaiciu dalmuo x1 / x2 = {num1 / num2}");
                }
        }
}