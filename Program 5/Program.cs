using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TREŚĆ ZADANIA
            //Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko
            //posła, premiera, sentarora, prezydenta.
            //Dane testowe : 21
            //Rezultat w terminalu:
            //Możesz zostać posłem

            // Pętla pobierająca od użytkownika wartość którą będziemy sprawdzali.
            int ageToCheck;
            bool userInput = false;
            do
            {
                Console.WriteLine("Podaj ile masz lat, wpisując odpowiednią cyfrę, po czym naciśnij klawisz \"ENTER\".");

                userInput = int.TryParse(Console.ReadLine(), out ageToCheck);

                if(!userInput)
                {
                    Console.WriteLine("Wprowadzona wartość nie jest wartością liczbową, ponów próbę używając w tym celu wartości liczbowych.");
                }
            }
            while (!userInput);

            // Instrukcja warunkowa sprawdzająca jakie stanowiska możemy zajmować z naszym wiekiem. 
            if (ageToCheck >= 21 & ageToCheck < 30)
            {
                Console.WriteLine("Możesz zostać posłem.");
                Console.WriteLine("Możesz zostać premierem.");
                Console.WriteLine("Nie możesz zostać senatorem.");
                Console.WriteLine("Nie możesz zostać prezydentem.");
            }
            else if (ageToCheck >= 30 & ageToCheck < 35)
            {
                Console.WriteLine("Możesz zostać posłem.");
                Console.WriteLine("Możesz zostać premierem.");
                Console.WriteLine("Możesz zostać senatorem.");
                Console.WriteLine("Nie możesz zostać prezydentem.");
            }
            else if (ageToCheck >= 35)
            {
                Console.WriteLine("Możesz zostać posłem.");
                Console.WriteLine("Możesz zostać premierem.");
                Console.WriteLine("Możesz zostać senatorem.");
                Console.WriteLine("Możesz zostać prezydentem.");
            }
            else if (ageToCheck >= 18 & ageToCheck < 21)
            {
                Console.WriteLine("Użytkownik nie spełnia wymagań dotyczących wieku w żadnym przypadku i nie może ubiegać się o żadne stanowisko.");
            }
            else
            {
                Console.WriteLine("Osoby niepełnoletnie nie mogą brać udziału w wyborach. Wracaj do szkoły!");
            }
        }
    }
}