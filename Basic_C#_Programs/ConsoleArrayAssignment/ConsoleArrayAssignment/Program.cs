using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializaing one dimensional array Part 1 
            string[] strNames = {"Rayne", "Kagan", "Severin", "Ferril", "Mynce"}; 
            Console.WriteLine("Enter a new name ");
            string newname = Console.ReadLine();

            for (int k = 0; k < strNames.Length; k++)
            {
                strNames[k] += newname;
                Console.WriteLine(strNames[k]);
            }

            //Part 2 
            bool x = true;          
            while(x)
            {

                for (int i = 0; i < strNames.Length; i++)
                {
                    strNames[i] = (strNames[i] + newname);
                    Console.WriteLine(strNames[i] + "\n ");
                    if (i == 4)
                    {
                        x = false; 
                    }
                }

                
            }

            int z = 0;
            while (z < 4)
            {
                Console.WriteLine(z);
                z++; 
            }

            int w = 0;
           while(w <= 4)
            {
                Console.WriteLine(w);
                w++; 
            }

           //Part 3
            List<string> Games = new List<string>() { "Halo", "Condemned", "Catwoman", "Aeon Flux" };
            Console.WriteLine("Enter a name");
            string listname = Console.ReadLine(); 

            for(int j = 0; j < Games.Count; j++)
            {

                if (Games[j] != listname)
                {
                    Console.WriteLine("\nIndex does not exist!");

                }
                else
                {
                    Console.WriteLine("\nYou've selected index: " + j);
                }                               

            }
           
            //Part 5
            List<string> Movies = new List<string>() { "Eight Crazy Nights", "Space Jam", "Dune", "The Lady in the Water", "Eight Crazy Nights" };
            Console.Write("\nEnter a movie ");
            string movie = Console.ReadLine();

            for (int d = 0; d < Movies.Count; d++)
            {
                if (Movies[d] == movie)
                {
                    Console.WriteLine("You choose: " + d);
                }
                else
                {
                    Console.WriteLine("The name you've entered does not exist!");
                }
            }
                List<string> Horror = new List<string>() {"Esther", "Jason", "Michael", "Freddy", "Johnny"};
                List<string> Horror2 = new List<string>();

            //Part 6
            foreach (string move in Horror)
            {
                if (Horror2.Contains(move))
                {
                    Console.WriteLine("These names have been mentioned!");

                }
                else
                {
                    Console.WriteLine("These names haven't been mentioned!");

                }
                Horror2.Add(move);


            }      
                  Console.ReadLine();  
        }
    }
}
