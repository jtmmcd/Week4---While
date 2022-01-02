using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numberi 1 - 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis on kasutaja mängu võitnud;
            //kasutajal on 3 katset, kui kasutaja ei arva numbrit ära siis mängu võidab arvuti;
            //*programm genereerib juhusliku numbrit üks kord.

            Random userRandom = new Random();
            int cpuNumber = userRandom.Next(1, 11);
            int i = 0;
            
            
            
            while (i < 3)
            {
                Console.WriteLine("Sisestage oma number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (cpuNumber == userNumber)
                {
                    Console.WriteLine("Arvasite numbri ära. Olete mängu võitnud!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number. Sul on veel {3 -i} korda jäänud.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
