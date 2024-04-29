using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TREŚĆ ZADANIA
            //Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach
            //Temp < 0 – cholernie piździ
            //Temp 0 – 10 – zimno
            //Temp 10 – 20 – chłodno
            //Temp 20 – 30 – w sam raz
            //Temp 30 – 40 – zaczyna być słabo, bo gorąco
            //Temp >= 40 – a weź wyprowadzam się na Alaskę.
            //Dane testowe : 41
            //Rezultat w terminalu:
            //a weź wyprowadzam się na Alaskę.

            // Pętla pozyskująca wartość temperatury od użytkownika i przypisująca ją do zmiennej która będzie później sprawdzana.
            double temperatureValue;
            bool userInput = false;
            do
            {
                Console.WriteLine("Witaj w programie do interpretacji temperatury! Aby kontynuować, naciśnij klawisz \"ENTER\".");
                Console.ReadKey();
                
                Console.WriteLine(string.Empty);
                
                Console.WriteLine("Wprowadz cyfrę reprezentującą interesującą cię temperaturę, a następnie naciśnij klawisz \"ENTER\".");
                userInput = double.TryParse(Console.ReadLine(), out temperatureValue);

                if (!userInput)
                {
                    Console.WriteLine("Wprowadzona wartość nie jest wartością liczbową, ponów próbę używając w tym celu wartości liczbowych.");
                }
            }
            while (!userInput);

            // Instrukcja warunkowa, interpretująca temperaturę wpisaną przez użytkownika. 
            string temperatureOpinion = temperatureValue switch
            {
                <0 => "Cholernie piździ.",
                >= 0 and <= 10 => "Zimno.",
                >= 10 and <= 20 => "Chłodno.",
                >= 20 and <= 30 => "W sam raz.",
                >= 30 and <= 40 => "Zaczyna być słabo, bo gorąco.",
                >= 40 => "A weź, wyprowadzam się na Alaskę.",
                _=> "Temperatura na tej planecie jest jakaś dziwna."
            };

            Console.WriteLine(string.Empty);
            
            // Metoda wyświetlająca wynik instrukcji. 
            Console.WriteLine($"{temperatureOpinion}");
        }
    }
}