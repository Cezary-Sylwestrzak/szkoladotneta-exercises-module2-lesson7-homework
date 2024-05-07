using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TREŚĆ ZADANIA
            //Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
            //Dane testowe : 14
            //Rezultat w terminalu:
            //14 jest liczbą dodatnią

            // Pętla pobierająca liczbę od użytkownika.
            int someValue;
            bool userInput = false;
            do
            {
                Console.WriteLine("Aby sprawdzić czy dana liczba jest dodatnia albo ujemna, podaj interesującą cię liczbę " +
                    "po czym naciśnij klawisz \"ENTER\".");

                userInput = int.TryParse(Console.ReadLine(), out someValue);

                if (!userInput)
                {
                    Console.WriteLine("Wprowadzona wartość nie jest wartością liczbową, ponów próbę używając w tym celu wartości liczbowych.");
                }
            }
            while (!userInput);
            
            // Instrukcja warunkowa sprawdzająca podaną liczbę.
            if (someValue >= 1)
            {
                Console.WriteLine($"Liczba \"{someValue}\" jest liczbą dodatnią.");
            }
            else 
            {
                Console.WriteLine($"Liczba \"{someValue}\" jest liczbą ujemną.");
            }
        }
    }
}