using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada tema lemmikvärv;
            //kui kasutaja sisestab "punane", siis konsool kuvab "oled romantik";
            //kui kasutaja sisestab "sinine", siis konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", siis konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "oled {userColor} ükssarvik";
            
            Console.WriteLine("Sisesta palun oma lemmikvärv");
            string userColor = Console.ReadLine();

            if (userColor == "punane") 
            {
                Console.WriteLine("Oled romantik.");
            }
            else if(userColor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            else if(userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik.");
            }

            Console.WriteLine("Kena päeva!");
           
            
          
        }
    }
}
