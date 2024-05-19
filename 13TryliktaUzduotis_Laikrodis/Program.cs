namespace TryliktaUzduotis_Laikrodis
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Padarykite skaitmeninį laikrodį, rodantį valandas, minutes ir sekundes.
                        // Valandom, minutėm ir sekundėm sugeneruoti panaudokite funkciją new Random().
                        // Sugeneruokite skaičių nuo 0 iki 300. Tai papildomos sekundės. Skaičių pridėkite prie jau sugeneruoto laiko.
                        // Atspausdinkite laikrodį prieš ir po sekundžių pridėjimo ir pridedamų sekundžių skaičių.
                        
                        Random rnd = new Random();
                        int valandos = rnd.Next(0, 23);
                        int minutes = rnd.Next(0, 59);
                        int sekundes = rnd.Next(0, 59);
                        int pridedamosSekundes = rnd.Next(0, 300);

                        Console.WriteLine($"{valandos.ToString("D2")}:{minutes.ToString("D2")}:{sekundes.ToString("D2")}");
                        Console.WriteLine(pridedamosSekundes);

                        pridedamosSekundes += sekundes;
                        int pridedamosMinutes = pridedamosSekundes / 60;
                        sekundes = pridedamosSekundes % 60;
                        minutes += pridedamosMinutes;
                        int pridedamosValandos = minutes / 60;
                        minutes = minutes % 60;
                        valandos += pridedamosValandos;

                        if (sekundes > 59)
                        {
                                sekundes -= 60;
                        }

                        if (minutes > 59)
                        {
                                minutes -= 60;
                        }

                        if (valandos > 23)
                        {
                                valandos -= 24;

                        }

                        Console.WriteLine($"{valandos.ToString("D2")}:{minutes.ToString("D2")}:{sekundes.ToString("D2")}");





                }
        }
}