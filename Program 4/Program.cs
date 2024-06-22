using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TREŚĆ ZADANIA
            //Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
            //Dane testowe : 2016
            //Rezultat w terminalu:
            //2016 jest rokiem przestępnym

            // Inicjalizacja zmiennej oraz pętla pobierająca od użytkownika informację który rok chce sprawdzić.
            int someYear;

            bool userInput = false;
            do
            {
                Console.WriteLine("Aby sprawdzić czy dany rok jest przestępny, wprowadź wartość reprezentującą intresujący cię rok " +
                    "po czym naciśnij klawisz\"ENTER\".");

                userInput = int.TryParse(Console.ReadLine(), out someYear);

                Console.WriteLine(string.Empty);

                if (!userInput || someYear < 0)
                {
                    Console.WriteLine("Wprowadzono błędne dane, ponów próbę.");
                } 
            }
            while (!userInput || someYear < 0);

            // Instrukcja warunkowa sprawdzająca czy dany rok jest rokiem przestępnym.
            if ((someYear % 4 != 0) || ((someYear % 4 == 0 && someYear % 100 == 0) && (someYear % 400 != 0))) 
            {
                Console.WriteLine($"Rok \"{someYear}\" nie jest rokiem przestępnym.");
            }
            else if ((someYear % 4 == 0 && someYear % 100 != 0) || ((someYear % 4 == 0 && someYear % 100 == 0) && (someYear % 400 == 0)))
            {
                Console.WriteLine($"Rok \"{someYear}\" jest rokiem przestępnym.");
            }
            
            Console.ReadLine();
        }
    }
}