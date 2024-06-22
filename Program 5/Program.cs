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

            // Deklaracja zmiennej oraz pętla pobierająca od użytkownika wartość którą będziemy sprawdzali.
            int ageToCheck; 

            bool userInput = false;
            do
            {
                Console.WriteLine("Podaj ile masz lat, wpisując odpowiednią cyfrę, po czym naciśnij klawisz \"ENTER\".");

                userInput = int.TryParse(Console.ReadLine(), out ageToCheck);

                if(!userInput || ageToCheck < 0)
                {
                    Console.WriteLine("Wprowadzono błędne dane, ponów próbę.");
                }
            }
            while (!userInput || ageToCheck < 0);

            // Instrukcja warunkowa sprawdzająca jakie stanowiska możemy zajmować względem podanego wieku.  
            if (ageToCheck > 17)  
            {
                if (ageToCheck > 20) 
                {
                    if (ageToCheck > 29) 
                    {
                        if (ageToCheck > 34)
                        {
                            Console.WriteLine("Możesz zostać posłem, premierem, senatorem albo prezydentem.");
                        }
                        else
                        {
                            Console.WriteLine("Możesz zostać posłem, premierem albo senatorem.");
                        }

                    }
                    else  
                    {
                        Console.WriteLine("Możesz zostać posłem albo premierem.");
                    }
                }
                else
                {
                    Console.WriteLine("Użytkownik nie spełnia wymagań dotyczących wieku w żadnym przypadku i nie może ubiegać się o żadne stanowisko.");
                }
            }
            else
            {
                Console.WriteLine("Osoby niepełnoletnie nie mogą brać udziału w wyborach. Wracaj do szkoły!");
            }
            
            Console.ReadLine();
        }
    }
}