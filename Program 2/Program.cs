using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TREŚĆ ZADANIA
            //Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.
            //Dane testowe : 15
            //Rezultat w terminalu:
            //15 jest liczbą nieparzystą

            // Pętla pobierająca liczbę od użytkownika. 
            int someValue;
            bool userInput = false;
            do
            {
                Console.WriteLine("Aby sprawdzić czy dana liczba jest parzysta bądz nieparzysta, podaj intresującą cię liczbę " +
                    "po czym naciśnij klawisz \"ENTER\".");

                userInput = int.TryParse(Console.ReadLine(), out someValue);

                if (!userInput)
                {
                    Console.WriteLine("Wprowadzona wartość nie jest wartością liczbową, ponów próbę używając w tym celu wartości liczbowych.");
                }
            }
            while (!userInput);

            // Instrukcja warunkowa sprawdzająca podaną przez użytkownika liczbę. 
            if (someValue % 2 == 0)
            {
                Console.WriteLine($"Liczba \"{someValue}\" jest liczbą parzystą.");
            }
            else
            {
                Console.WriteLine($"Liczba \"{someValue}\" jest liczbą nieparzystą.");
            }
        }
    }
}