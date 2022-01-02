using System;

namespace PIN__Infinite_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutajal sisestada pin kood;
            //programm võrdleb sisestatud pin arvuga 1234;
            //kui sisestatud pin kood on 1234 siis konsool kuvab "tere tulemast"
            //kui pin kood on vale siis konsool kuvab "vale pin. Proovi uuesti"

            //katsete arv on piiramatu

            bool loopActive = true; //boolean --> true/false
            int i = 0;

            while(loopActive)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestanud.");
                }

            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
