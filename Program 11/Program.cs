namespace Program_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TREŚĆ ZADANIA
            //Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
            //Ocena  | Opis
            //  6    | Celujący
            //  5    | Bardzo dobry
            //  4    | Dobry
            //  3    | Dostateczny
            //  2    | Dopuszczający
            //  1    | Niedostateczny
            //Dane testowe: 3
            //Rezultat w terminalu:
            //Dostateczny

            // Pętla pozyskująca wartość od użytkownika.
            int scoreValue;
            bool userInput = false;
            do
            {
                Console.WriteLine("Wprowadz liczbę w zakresie od 1 do 6.");
                
                Console.WriteLine(string.Empty);

                do
                {
                    userInput = int.TryParse(Console.ReadLine(), out scoreValue);
                    
                    if ((scoreValue < 0 || scoreValue > 6) || (scoreValue == 0))
                    {
                        Console.WriteLine("Wprowadzona wartość jest błędna, ponów próbę używając w tym celu wartości od 1 do 6.");
                    }
                }
                while ((scoreValue < 0 || scoreValue > 6) || (scoreValue == 0));    
                
                if (!userInput)
                {
                    Console.WriteLine("Wprowadzona wartość nie jest wartością liczbową, ponów próbę używając w tym celu wartości liczbowych.");
                }
            }
            while (!userInput);

            // Instrukcja warunkowa zmieniająca wartość wprowadzoną przez użytkownika na konkretny wynik w typie string. 
            string scoreEquivalent = scoreValue switch
            {
                6 => "Celujący.",
                5 => "Bardzo dobry.",
                4 => "Dobry.",
                3 => "Dostateczny.",
                2 => "Dopuszczający.",
                1 => "Niedostateczny.",
                _ => "Podano błędne dane, nie ma takiej oceny. Podaj ocenę jeszcze raz, tym razem wybierz wartość od 1 do 6."
            };

            Console.WriteLine(string.Empty);
            
            Console.WriteLine(scoreEquivalent);
        }
    }
}