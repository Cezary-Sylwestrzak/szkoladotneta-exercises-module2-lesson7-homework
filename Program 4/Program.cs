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

            // Pętla pobierająca informację na temat roku który chcemy sprawdzić.
            int someYear;
            bool userInput = false;
            do
            {
                Console.WriteLine("Aby sprawdzić czy dany rok jest przestęny, podaj wartość reprezentującą intresujący cię rok " +
                    "po czym naciśnij klawisz \"ENTER\".");

                userInput = int.TryParse(Console.ReadLine(), out someYear);

                if (!userInput)
                {
                    Console.WriteLine("Wprowadzona wartość nie jest wartością liczbową, ponów próbę używając w tym celu wartości liczbowych.");
                }
            }
            while (!userInput);
            
            // Instrukcja warunkowa zawierająca metodę która sprawdza czy dany rok jest rokiem przestępnym. Użyłem metody systemowej ale zdaję sobie
            // również sprawę że można to napisać w postaci warunków logicznych.
            if (DateTime.IsLeapYear(someYear))
            {
                Console.WriteLine($"Rok \"{someYear}\" jest rokiem przestępnym.");
            }
            else
            {
                Console.WriteLine($"Rok \"{someYear}\" nie jest rokiem przestępnym.");
            }
        }
    }
}