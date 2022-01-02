using System;

namespace Loops_and_random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutajal sisestada pin kood;
            //programm võrdleb sisestatud pin arvuga 1234;
            //kui sisestatud pin kood on 1234 siis konsool kuvab "tere tulemast"
            //kui pin kood on vale siis konsool kuvab "vale pin. Proovi uuesti"
            //kasutajal on 3 katset. i < 3

            int i = 0; // i - iteratsioon
            
            while(i < 3) //while loop 
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    //i = i + 1 == i++        (i-- miinus 1)
                    i++;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");
                }
                
                
            }

           
            Console.WriteLine("Kena päeva!");

        }
    }
}
