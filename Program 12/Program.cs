using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TREŚĆ ZADANIA
            //Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę
            //Dane testowe : 4
            //Rezultat w terminalu:
            //Czwartek

            // Pętla pobierająca od użytkownika wartość której odpowiadają nazwy dni tygodnia. 
            int numberOfDay;
            do
            {
                Console.WriteLine("Podaj numer dnia tygodnia który cię interesuje. Wybierz liczbę pomiędzy 1 - 7.");

                int.TryParse(Console.ReadLine(), out numberOfDay);
                if (numberOfDay < 0 || numberOfDay > 8)
                {
                    Console.WriteLine("Podano błędne dane, podaj numer dnia tygodnia jeszcze raz, tym razem wybierz wartość od 1 do 7.");
                }
            }
            while (numberOfDay <= 0 || numberOfDay >= 8);
            
            // Instrukcja warunkowa decydująca o przydziale nazw dni względem numeru dnia. 
            string nameOfTheDay = numberOfDay switch
            {
                7 => "Niedziela.",
                6 => "Sobota.",
                5 => "Piątek.",
                4 => "Czwartek.",
                3 => "Środa.",
                2 => "Wtorek.",
                1 => "Poniedziałek.",
                _ => "Podano błędne dane, podaj numer dnia tygodnia jeszcze raz, tym razem wybierz wartość od 1 do 7."
            };

            Console.WriteLine(string.Empty);

            Console.WriteLine(nameOfTheDay);
        }
    }
}