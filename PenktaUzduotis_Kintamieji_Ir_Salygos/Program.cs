namespace PenktaUzduotis_Prisistatymas
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite 4 kintamuosius, kurie saugotų jūsų vardą, pavardę, gimimo metus ir šiuos metus (nebūtinai tikrus).
                        // Parašykite kodą, kuris pagal gimimo metus paskaičiuotų jūsų amžių ir naudodamas vardo ir pavardės kintamuosius
                        // atspausdintų tokį sakinį :"Aš esu Vardenis Pavardenis. Man yra XX metai(ų)".
                        
                        string vardas = "Povilas";
                        string pavarde = "Azubalis";
                        int gimimoMetai = 1997;
                        int einamiejiMetai = 2024;
                        int amzius = EinamiejiMetai - GimimoMetai;
                        Console.WriteLine($"Aš esu {Vardas} {Pavarde}. Man yra {amzius} metai(u).\n");

                }
        }
}