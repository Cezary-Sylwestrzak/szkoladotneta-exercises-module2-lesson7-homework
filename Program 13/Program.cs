using System.Security.Cryptography.X509Certificates;

namespace Program_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TREŚĆ ZADANIA
            //Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem
            //Podaj pierwszą liczbę:
            // …
            //Podaj drugą liczbę:
            // …
            //Podaj numer operacji do wykonania:
            //1.Dodawanie
            //2.Odejmowanie
            //3.Mnożenie
            //4.Dzielenie
            // …
            //Twój wynik to:

            // Deklaracja zmiennych oraz pętla pobierająca od użytkownika wartości na których będziemy pracowali. 
            double firstValue;
            double secondValue;
            double choiceOfOperation;

            bool userInputOne = false;
            bool userInputTwo = false;
            do
            {
                Console.WriteLine("Podaj pierwszą liczbę.");
                userInputOne = double.TryParse(Console.ReadLine(), out firstValue);

                Console.WriteLine(string.Empty);

                Console.WriteLine("Podaj drugą liczbę.");
                userInputTwo = double.TryParse(Console.ReadLine(), out secondValue);

                Console.WriteLine(string.Empty);

                if (!userInputOne || !userInputTwo)
                {
                    Console.WriteLine("Wprowadzona wartość nie jest wartością liczbową, ponów próbę używając w tym celu wartości liczbowych.");
                }
            }
            while (!userInputOne || !userInputTwo);

            // Pętla z menu możliwych operacji do wyboru. 
            bool userInputThree = false;
            do
            {
                Console.WriteLine("Wybierz operację do wykonania. Wprowadź liczbę odpowiadającą operacji która cię interesuje.");

                Console.WriteLine(string.Empty);

                Console.WriteLine("1.Dodawanie.");
                Console.WriteLine("2.Odejmowanie.");
                Console.WriteLine("3.Mnożenie.");
                Console.WriteLine("4.Dzielenie.");

                Console.WriteLine(string.Empty);

                userInputThree = double.TryParse(Console.ReadLine(), out choiceOfOperation);

                if (choiceOfOperation == 4 && (firstValue == 0 || secondValue == 0))
                {
                    Console.WriteLine("Niedozwolona operacja! Nie można dzielić przez zero. Ponów wybór, tym razem wybierając operację możliwą do wykonania.");
                    Console.WriteLine(string.Empty);
                }
                else if (!userInputThree)
                {
                    Console.WriteLine("Wprowadzona wartość nie jest wartością liczbową, ponów próbę używając w tym celu wartości liczbowych.");
                    Console.WriteLine(string.Empty);
                }
                else if (choiceOfOperation < 0)
                {
                    Console.WriteLine("Wprowadzono błędne dane, ponów próbę.");
                    Console.WriteLine(string.Empty);
                }
            }
            while ((choiceOfOperation == 4 && (firstValue == 0 || secondValue == 0) || !userInputThree) || choiceOfOperation < 0);

            Console.WriteLine(string.Empty);

            // Instrukcja warunkowa uruchamiająca daną operację matematyczną na podstawie wyboru użytkownika.
            switch (choiceOfOperation)
            {
                case 1:
                    double sumOfNumbers = firstValue + secondValue;
                    Console.WriteLine($"Twój wynik to: {sumOfNumbers}.");
                    break;
                case 2:
                    double differenceOfNumbers = firstValue - secondValue;
                    Console.WriteLine($"Twój wynik to: {differenceOfNumbers}.");
                    break;
                case 3:
                    double productOfNumbers = firstValue * secondValue;
                    Console.WriteLine($"Twój wynik to: {productOfNumbers}.");
                    break;
                case 4:
                    double quotientOfNumbers = firstValue / secondValue;
                    Console.WriteLine($"Twój wynik to: {quotientOfNumbers}.");
                    break;
                default:
                    Console.WriteLine("Wprowadzono błędne dane, ponów wybór operacji zawężając liczby do zakresu 1 - 4.");
                    break;
            }
            
            Console.ReadLine();
        }
    }
}           