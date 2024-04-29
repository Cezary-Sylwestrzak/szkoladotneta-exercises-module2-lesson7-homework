namespace Program_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TREŚĆ ZADANIA
            //Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa
            //Dane testowe:
            //25
            //63
            //79
            //Rezultat w terminalu:
            //79 jest największa z podanych
            
            // Zadeklarowanie z góry zmiennych których będzemy używali.
            double valueNumberOne;
            double valueNumberTwo;
            double valueNumberThree;
            
            // Przypisanie wartości do zmiennych.
            bool assigningValuesToVariables = false;
            do
            {
                Console.WriteLine("Witaj w programie do porównywania liczb całkowitych, wpisz liczbę" +
                    ", dodatnią albo ujemną, po czym zatwierdz ją wciskając klawisz \"ENTER\", powtórz czynność trzykrotnie abyś mógł kontynuować.");
                
                Console.WriteLine(string.Empty);

                assigningValuesToVariables = double.TryParse(Console.ReadLine(), out valueNumberOne);
                assigningValuesToVariables = double.TryParse(Console.ReadLine(), out valueNumberTwo);
                assigningValuesToVariables = double.TryParse(Console.ReadLine(), out valueNumberThree);
                if (!assigningValuesToVariables)
                {
                    Console.WriteLine("Wpisana wartość jest nieprawidłowa, wpisz ponownie liczbę używając do tego klawiatury numerycznej.");
                }
            }
            while (!assigningValuesToVariables);

            Console.WriteLine(string.Empty);
            
            // Instrukcja warunkowa sprawdzająca która zmienna jest największa. 
            if (valueNumberOne > valueNumberTwo && valueNumberOne > valueNumberThree)
            {
                Console.WriteLine($"\"{valueNumberOne}\" to największa liczba.");
            }
            else if (valueNumberTwo > valueNumberOne && valueNumberTwo > valueNumberThree)
            {
                Console.WriteLine($"\"{valueNumberTwo}\" to największa liczba.");
            }
            else if (valueNumberThree > valueNumberOne && valueNumberThree > valueNumberTwo)
            {
                Console.WriteLine($"\"{valueNumberThree}\" to największa liczba.");
            }
            else if (valueNumberOne == valueNumberTwo && valueNumberTwo == valueNumberThree)
            {
                Console.WriteLine("Wszystkie liczby są równe.");
            }
            else
            {
                Console.WriteLine("Żadna z zmiennych nie ma przypisanej jakiejkolwiek wartości.");
            } 
        }
    }
}