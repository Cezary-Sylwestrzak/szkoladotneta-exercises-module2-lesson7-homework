using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module_2_Lesson_7___Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TREŚĆ ZADANIA
            //Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
            //Dane testowe:
            //a: 5
            //b: 5
            //Rezultat w terminalu:
            //5 i 5 są równe

            // Pętla pobierająca liczby od użytkownika i przypisująca uzyskane wartości do wcześniej zadeklarowanych zmiennych.
            int valueNumberOne;
            int valueNumberTwo;
            bool userInput = false;
            do
            {
                Console.WriteLine("Aby sprawdzić czy liczby są równe, podaj dwie liczby które cię intresują, każdą zatwierdzając klawiszem \"ENTER\".");

                userInput = int.TryParse(Console.ReadLine(), out valueNumberOne);
                userInput = int.TryParse(Console.ReadLine() , out valueNumberTwo);

                if (!userInput)
                {
                    Console.WriteLine("Wprowadzona wartość nie jest wartością liczbową, ponów próbę używając w tym celu wartości liczbowych.");
                }
            }
            while (!userInput);
            
            // Instrukcja warunkowa sprawdzająca czy podane przez użytkownika liczby są równe. 
            if (valueNumberOne == valueNumberTwo)
            {
                Console.WriteLine($"Podane przez użytkownika liczby \"{valueNumberOne}\" i \"{valueNumberTwo}\" są równe.");
            }
            else
            {
                Console.WriteLine($"Podane przez użytkownika liczby \"{valueNumberOne}\" i \"{valueNumberTwo}\" nie są równe.");
            }
        }
    }
}