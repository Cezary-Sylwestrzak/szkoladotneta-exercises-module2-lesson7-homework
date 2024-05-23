using System;
using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection;
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

            bool inputData = false;
            do
            {
                Console.WriteLine("Aby kontynuować, wprowadz cyfrę reprezentującą długość odcinka który cię interesuje, a następnie naciśnij klawisz \"ENTER\". " +
                    "Powtórz czynność trzykrotnie aby wprowadzić wszystkie wymagane dane.");
                // Pętla zagnieżdżona dla odcinka "A".
                do
                {
                    inputData = double.TryParse(Console.ReadLine(), out A);
                    if (A < 0)
                    {
                        Console.WriteLine("Ujemne długości odcinków nie mogą stworzyć figury geometrycznej, wprowadź długość odcinka ponownie, " +
                            "tym razem używając wartości dodatnich.");
                    }
                }
                while (A < 0);
                // Pętla zagnieżdżona dla odcinka "B".
                do
                {
                    inputData = double.TryParse(Console.ReadLine(), out B);
                    if (B < 0)
                    {
                        Console.WriteLine("Ujemne długości odcinków nie mogą stworzyć figury geometrycznej, wprowadź długość odcinka ponownie, " +
                            "tym razem używając wartości dodatnich.");
                    }
                }
                while (B < 0);
                // Pętla zagnieżdżona dla odcinka "C".
                do
                {
                    inputData = double.TryParse(Console.ReadLine(), out C);
                    if (C < 0)
                    {
                        Console.WriteLine("Ujemne długości odcinków nie mogą stworzyć figury geometrycznej, wprowadź długość odcinka ponownie, " +
                            "tym razem używając wartości dodatnich.");
                    }
                }
                while (C < 0);
              
                if (!inputData)
                {
                    Console.WriteLine("Wprowadzona wartość nie jest wartością liczbową, ponów próbę używając w tym celu wartości liczbowych.");
                }
            }
            while (!inputData);

            // Instrukcja warunkowa decydująca o tym czy można zbudować trójkąt z podanych przez użytkownika długości.

            // Odcinek "A" jest najdłuższy.
            if (A > B && A > C)
            {
                if (C + B > A)
                {
                    Console.WriteLine("Można zbudować trójkąt.");
                }
                else if (C + B <= A)
                {
                    Console.WriteLine("Nie można zbudować trójkąta.");
                }
            }
            // Odcinek "B" jest najdłuższy.
            else if (B > C && B > A)
            {
                if (C + A > B)
                {
                    Console.WriteLine("Można zbudować trójkąt.");
                }
                else if (C + A <= B)
                {
                    Console.WriteLine("Nie można zbudować trójkąta.");
                }
            }
            // Odcinek "C" jest najdłuższy.
            else if (C > B && C > A)
            {
                if (A + B > C)
                {
                    Console.WriteLine("Można zbudować trójkąt.");
                }
                else if (A + B <= C)
                {
                    Console.WriteLine("Nie można zbudować trójkąta.");
                }
            }
            // Wszystkie odcinki są równe - występuje przypadek trójkąta równobocznego.
            else if (A == B && B == C)
            {
                Console.WriteLine("Można zbudować trójkąt.");
            }
            // 2 z 3 odcinków są równe a ostatnia długość jest najmniejsza.
            else if ((A == B && C < A || C < B) || ((B == C && A < B || A < C) || (A == C && B < A || B < C)))
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