namespace DevintaUzduotis_KiekSpecifiniuElementuBEMASYVO
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite keturis kintamuosius ir new Random() funkcija
                        // sugeneruokite jiems reikšmes nuo 0 iki 2.
                        // Suskaičiuokite kiek yra nulių, vienetų ir dvejetų. (sprendimui masyvo nenaudoti).
                        
                        Random rnd = new Random();
                        int a1 = rnd.Next(0, 2);
                        int a2 = rnd.Next(0, 2);
                        int a3 = rnd.Next(0, 2);
                        int a4 = rnd.Next(0, 2);
                        int i = 0;
                        int j = 0;
                        int k = 0;

                        if (a1 == 0) i++;
                        if (a2 == 0) i++;
                        if (a3 == 0) i++;
                        if (a4 == 0) i++;

                        if (a1 == 1) j++;
                        if (a2 == 1) j++;
                        if (a3 == 1) j++;
                        if (a4 == 1) j++;

                        if (a1 == 2) k++;
                        if (a2 == 2) k++;
                        if (a3 == 2) k++;
                        if (a4 == 2) k++;

                        Console.WriteLine($"a1: {a1} a2: {a2} a3: {a3} a4: {a4}\n");
                        Console.WriteLine($"Nuliu suma: {i}\nVienetu suma: {j}\nDvejetu suma: {k}\n");
                }
        }
}