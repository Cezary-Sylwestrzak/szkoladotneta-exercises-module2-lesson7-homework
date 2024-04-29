using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TREŚĆ ZADANIA
            //Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg.Następujących kryteriów:
            //Wynik z Matury z matematyki powyżej 70
            //Wynik z fizyki powyżej 55
            //Wynik z chemii powyżej 45
            //Łączny wynik z 3 przedmiotów powyżej 180
            //Albo
            //Wynik z matematyki i jednego przedmiotu powyżej 150
            //Dane testowe:
            //Matematyka 80
            //Fizyka 71
            //Chemia 0
            //Rezultat w terminalu:
            //Kandydat dopuszczony do rekrutacji

            // Zadeklarowanie trzech zmiennych oraz użycie pętli w celu pozyskania wartości od użytkownika, a następnie przypisania wartości
            // do tychże zmiennych.
            int mathematicsPoints;
            int physicsPoints;
            int chemistryPoints;
            bool userInput = false;
            do
            {
                Console.WriteLine("Witaj uczniu! Program ma za zadanie sprawdzić czy uzyskane przez Ciebie wyniki na maturze kwalifikują " +
                    "cię do ubiegania się o miejsce na studia.");
                Console.WriteLine("W tym celu będzie wymagane wprowadzenie przez Ciebie trzech liczb. Aby kontynuować, naciśnij klawisz \"ENTER\".");
                
                Console.ReadKey();
                
                Console.WriteLine(string.Empty);
                
                Console.WriteLine("Wprowadz cyfrę reprezentującą liczbę punktów uzyskanych przez Ciebie z matematyki.");
                userInput = int.TryParse(Console.ReadLine(), out mathematicsPoints);

                Console.WriteLine("Wprowadz cyfrę reprezentującą liczbę punktów uzyskanych przez Ciebie z fizyki.");
                userInput = int.TryParse(Console.ReadLine(), out physicsPoints);

                Console.WriteLine("Wprowadz cyfrę reprezentującą liczbę punktów uzyskanych przez Ciebie z chemii.");
                userInput = int.TryParse(Console.ReadLine(), out chemistryPoints);

                if (!userInput)
                {
                    Console.WriteLine("Wprowadzona wartość nie jest wartością liczbową, ponów próbę używając w tym celu wartości liczbowych.");
                }
            }
            while (!userInput);

            Console.WriteLine(string.Empty);
            
            // Wypisanie wartości podanych przez użytkownika w celu sprawdzenia działania pętli i poinformowania go o wpisanych wartościach.   
            Console.WriteLine($"Twój wynik z matematyki to \"{mathematicsPoints}\" punktów.");
            Console.WriteLine($"Twój wynik z fiyki to \"{physicsPoints}\" punktów.");
            Console.WriteLine($"Twój wynik z chemii to \"{chemistryPoints}\" punktów.");

            Console.WriteLine(string.Empty);

            Console.WriteLine("Aby sprawdzić czy zdobyte przez ciebie punkty uprawniają cię do ubiegania się o przyjęcie na studia, naciśnij klawisz \"ENTER\".");
            
            Console.ReadKey();
            
            // Instrukcja warunkowa weryfikująca zdobyte punkty i decydująca czy użytkownik dostał się na rektutacje na studia.
            if (mathematicsPoints + physicsPoints + chemistryPoints > 180)
            {
                if (mathematicsPoints >70 && physicsPoints >55 &&  chemistryPoints >45)
                {
                    Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
                }
                else
                {
                    Console.WriteLine("Kandydat niedopuszczony do rekrutacji.");
                }
            }
            else if (mathematicsPoints + (physicsPoints | chemistryPoints) > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji.");
            }
        }
    }
}