using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numberi 1 - 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis on kasutaja mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhusliku numbrit üks kord.

            Random userRandom = new Random();
            int cpuNumber = userRandom.Next(1, 11);

            while (true)
            {
                Console.WriteLine("Sisestage oma number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if(cpuNumber == userNumber)
                {
                    Console.WriteLine("Arvasite numbri ära. Olete mängu võitnud!");
                    break;
                }
                else
                {
                    Console.WriteLine("Vale number. Proovi veel.");
                }
            }

        }
    }
}
