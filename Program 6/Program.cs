using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TREŚĆ ZADANIA
            //Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
            //Dane testowe : 140
            //Rezultat w terminalu:
            //Jesteś krasnoludem

            // Skomplikowałem sobie trochę zadanie i podzieliłem wzrost na dwie kategorie, mężczyzn oraz kobiety. Wydawało mi się to bardziej logiczne. 
            
            // Pętla dająca wybór pomiędzy dwoma płciami.
            int selectedGender;
            bool choiceofGender = false;
            do
            {
                Console.WriteLine("Wybierz swoją płeć wybierając numer \"1\" albo \"2\" po czym naciśnij klawisz \"ENTER\".");
                
                Console.WriteLine("1.Mężczyzna");
                Console.WriteLine("2.Kobieta");
                
                choiceofGender = int.TryParse(Console.ReadLine(), out selectedGender);
                if (!choiceofGender)
                {
                    Console.WriteLine("Wybrano niewłaściwy numer, wybierz ponownie swoją płeć wybierając numer \"1\" albo \"2\".");
                }
            }
            while (!choiceofGender);
            
            // Wprowadzenie wartości dla wzrostu, zastosowałem typ double aby można było wpisać wartość po przecinku.   
            double heightToCheck;
            bool userInput = false;
            do
            {
                Console.WriteLine("Podaj swój wzrost. W tym celu wpisz odpowiednią liczbę po czym naćiśnij klawisz \"ENTER\".");

                userInput = double.TryParse(Console.ReadLine(), out heightToCheck);

                if (!userInput)
                {
                    Console.WriteLine("Wprowadzona wartość nie jest wartością liczbową, ponów próbę używając w tym celu TYLKO wartości liczbowych.");
                }
            }
            while (!userInput);

            // Instrukcja warunkowa sprawdzająca która płeć została wybrana.
            if (selectedGender == 1)
            {
                // Instrukcja warunkowa która zostanie zastosowana jeśli wybraliśmy mężczyznę.
                switch (heightToCheck)
                {
                    case <= 125.4:
                        Console.WriteLine("Jesteś karłem!");
                        break;
                    case double when (heightToCheck >= 125.5 && heightToCheck <= 155.4):
                        Console.WriteLine("Jesteś bardzo niski!");
                        break;
                    case double when (heightToCheck >= 155.5 && heightToCheck <= 161.4):
                        Console.WriteLine("Jesteś niski!");
                        break;
                    case double when (heightToCheck >= 161.5 && heightToCheck <= 167.9):
                        Console.WriteLine("Twój wzrost jest poniżej średniej!");
                        break;
                    case double when (heightToCheck >= 168 && heightToCheck <= 174.4):
                        Console.WriteLine("Jesteś średniego wzrostu!");
                        break;
                    case double when (heightToCheck >= 174.5 && heightToCheck <= 180.9):
                        Console.WriteLine("Twój wzrost jest powyżej średniej!");
                        break;
                    case double when (heightToCheck >= 181 && heightToCheck <= 187.4):
                        Console.WriteLine("Jesteś wysoki!");
                        break;
                    case double when (heightToCheck >= 187.5 && heightToCheck <= 200.4):
                        Console.WriteLine("Jesteś bardzo wysoki!");
                        break;
                    case >= 200.5:
                        Console.WriteLine("Jesteś skrajnie wysoki!");
                        break;
                    default:
                        Console.WriteLine("Twój wzrost jest poza skalą, czy napewno jesteś człowiekiem?");
                        break;
                }
            }
            else
            {
                // Instrukcja warunkowa która zostanie zastosowana jeśli wybraliśmy kobietę.
                switch (heightToCheck)
                {
                    case <= 125.4:
                        Console.WriteLine("Jesteś karlicą!");
                        break;
                    case double when (heightToCheck >= 125.5 && heightToCheck <= 147.4):
                        Console.WriteLine("Jesteś bardzo niska!");
                        break;
                    case double when (heightToCheck >= 147.5 && heightToCheck <= 152.9):
                        Console.WriteLine("Jesteś niska!");
                        break;
                    case double when (heightToCheck >= 153 && heightToCheck <= 158.4):
                        Console.WriteLine("Twój wzrost jest poniżej średniej!");
                        break;
                    case double when (heightToCheck >= 158.5 && heightToCheck <= 163.9):
                        Console.WriteLine("Jesteś średniego wzrostu!");
                        break;
                    case double when (heightToCheck >= 164 && heightToCheck <= 169.4):
                        Console.WriteLine("Twój wzrost jest powyżej średniej!");
                        break;
                    case double when (heightToCheck >= 169.5 && heightToCheck <= 174.4):
                        Console.WriteLine("Jesteś wysoka!");
                        break;
                    case double when (heightToCheck >= 174.5 && heightToCheck <= 200.4):
                        Console.WriteLine("Jesteś bardzo wysoka!");
                        break;
                    case >= 200.5:
                        Console.WriteLine("Jesteś skrajnie wysoka!");
                        break;
                    default:
                        Console.WriteLine("Twój wzrost jest poza skalą, czy napewno jesteś człowiekiem?");
                        break;
                }
            }
        }
    }
}