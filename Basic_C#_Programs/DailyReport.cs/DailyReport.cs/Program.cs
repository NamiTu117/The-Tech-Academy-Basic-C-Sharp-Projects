using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \n");
            Console.ReadLine();

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What course are you in?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            string num = Console.ReadLine();

        
           
            Console.WriteLine("Do you need any help with anything? Please answer 'true' or 'false");
            bool answer = true;
            bool answer2 = false;
            string truce = Convert.ToString(answer);
            string no = Convert.ToString(answer2);
            string truce = Console.ReadLine(); 
            
            
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics \n");
            string pare = Console.ReadLine();

            Console.WriteLine("Is there any more feedback you'd like to provide? \n");
            string comment = Console.ReadLine();


            Console.WriteLine("Thank you for all your answers! An instructor will answer these shortly. Thank you!");
            Console.ReadLine();

        }
    }
}
