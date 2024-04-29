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

            // Pętla pobierająca od użytkownika wartości liczby pierwszej oraz drugiej. 
            double firstValue;
            double secondValue;
            double userInput;
            do
            {
                Console.WriteLine("Podaj pierwszą liczbę.");

                double.TryParse(Console.ReadLine(), out firstValue);

                Console.WriteLine(string.Empty);

                Console.WriteLine("Podaj drugą liczbę.");

                double.TryParse(Console.ReadLine(), out secondValue);
            }
            while (firstValue == null || secondValue == null);

            // Wypisanie możliwości oraz wybór operacji przez użytkownika.
            
            Console.WriteLine(string.Empty);
            
            Console.WriteLine("Wybierz operację do wykonania. Wprowadź liczbę odpowiadającą operacji która cię interesuje.");
            
            Console.WriteLine(string.Empty);
            
            Console.WriteLine("1.Dodawanie.");
            Console.WriteLine("2.Odejmowanie.");
            Console.WriteLine("3.Mnożenie.");
            Console.WriteLine("4.Dzielenie.");

            Console.WriteLine(string.Empty);

            userInput = double.Parse(Console.ReadLine());

            Console.WriteLine(string.Empty);

            // Instrukcja warunkowa uruchamiająca daną operację matematyczną na podstawie wyboru użytkownika.
            switch (userInput)
            {
                case 1 :
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
        }
    }
}           