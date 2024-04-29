using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TREŚĆ ZADANIA
            //Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt
            //Dane testowe : 40 55 65
            //Rezultat w terminalu:
            //Można zbudować trójkąt

            // Zadeklarowanie zmiennych które będziemy sprawdzać oraz stworzenie pętli pozyskującej informację od użytkownika. Dodatkowo pętla ma 
            // możliwość filtrowania wprowadzonych danych pod kątem ujemych wartości.
            double A;
            double B;
            double C;

            bool userInput = false;
            do
            {
                Console.WriteLine("Witaj w programie w którym sprawdzisz czy z podanych przez Ciebie boków jesteśmy w stanie zbudować trójkąt. " +
                    "Aby kontynuować, wprowadz cyfrę reprezentującą interesującą cię długość odcinka, a następnie naciśnij klawisz \"ENTER\". " +
                    "Powtórz czynność trzykrotnie aby wprowadzić wszystkie wymagane dane.");
                // Pętla zagnieżdżona dla odcinka "A".
                do
                {
                    userInput = double.TryParse(Console.ReadLine(), out A);
                    if (A < 0)
                    {
                        Console.WriteLine("Ujemne długości odcinków nie mogą stworzyć figury geometrycznej, wprowadź długość odcinka ponownie, " +
                            "tym razem używając wartości dodatnich.");
                    }
                }
                while ((A < 0));
                // Pętla zagnieżdżona dla odcinka "B".
                do
                {
                    userInput = double.TryParse(Console.ReadLine(), out B);
                    if (B < 0)
                    {
                        Console.WriteLine("Ujemne długości odcinków nie mogą stworzyć figury geometrycznej, wprowadź długość odcinka ponownie, " +
                            "tym razem używając wartości dodatnich.");
                    }
                }
                while ((B < 0));
                // Pętla zagnieżdżona dla odcinka "C".
                do
                {
                    userInput = double.TryParse(Console.ReadLine(), out C);
                    if (C < 0)
                    {
                        Console.WriteLine("Ujemne długości odcinków nie mogą stworzyć figury geometrycznej, wprowadź długość odcinka ponownie, " +
                            "tym razem używając wartości dodatnich.");
                    }
                }
                while ((C < 0));
              
                if (!userInput)
                {
                    Console.WriteLine("Wprowadzona wartość nie jest wartością liczbową, ponów próbę używając w tym celu wartości liczbowych.");
                }
            }
            while (!userInput);

            // Instrukcja warunkowa decydująca o tym czy można zbudować trójkąt z podanych przez użytkownika długości odcinków. Spersonalizowana 
            // pod kątem najdłuższego odcinka.

            // Część instrukcji wykonywana jeśli odcinek "A" jest najdłuższy.
            if ((A > B && A > C || A == B && B == C))
            {
                if (C + B > A)
                {
                    Console.WriteLine("Można zbudować trójkąt.");
                }
                else if ((C + B < A || C + B == A) || (C + B == A || (A == B && C < A || C < B)))
                {
                    Console.WriteLine("Nie można zbudować trójkąta.");
                }
            }
            // Część instrukcji wykonywana jeśli odcinek "B" jest najdłuższy.
            else if ((B > C && B > A || B == A && A == C))
            {
                if (C + A > B)
                {
                    Console.WriteLine("Można zbudować trójkąt.");
                }
                else if ((C + A < B || A + C == B) || (A + C == B || (B == C && A < B || A < C)))
                {
                    Console.WriteLine("Nie można zbudować trójkąta.");
                }
            }
            // Część instrukcji wykonywana jeśli odcinek "C" jest najdłuższy.
            else if ((C > B && C > A || C == B && B == A))
            {
                if (A + B > C)
                {
                    Console.WriteLine("Można zbudować trójkąt.");
                }
                else if ((A + B < C || A + B == C) || (A + B == C || (A == C && B < A || B < C)))
                {
                    Console.WriteLine("Nie można zbudować trójkąta.");
                }
            }
            // Część instrukcji wykonywana jeśli wszystkie odcinki są równe czyli występuje przypadek trójkąta równobocznego. 
            else if (A == B && B == C)
            {
                Console.WriteLine("Można zbudować trójkąt.");
            }
            else
            {
                Console.WriteLine("Wprowadzono błędne dane, zacznij od początku.");
            }
        }
    }
}         