using System;

namespace TreciaUzduotis_AmziausSkaiciavimas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite savo gimimo metus:");
            int gimimometai = int.Parse(Console.ReadLine());
            int data = DateTime.Now.Year;
            float amzius = data-gimimometai;

            Console.WriteLine($"\nJums yra {amzius} metai");


        }
    }
}