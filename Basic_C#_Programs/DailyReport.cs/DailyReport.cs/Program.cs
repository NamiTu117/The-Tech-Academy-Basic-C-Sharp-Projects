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
            //intro
            Console.WriteLine("The Tech Academy \n");
            Console.ReadLine();

            //prompt user for input
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("\nWhat course are you in?");
            string course = Console.ReadLine();

            Console.WriteLine("\nWhat page number?");
            string num = Console.ReadLine();

        
           
            Console.WriteLine("\nDo you need any help with anything? Please answer 'true' or 'false");
            //boolean conversion for input
            bool answer = Convert.ToBoolean(Console.ReadLine());

             
            
            
            Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics \n");
            string pare = Console.ReadLine();

            Console.WriteLine("Is there any more feedback you'd like to provide? \n");
            string comment = Console.ReadLine();

            //program end
            Console.WriteLine("Thank you for all your answers! An instructor will answer these shortly. Thank you!");
            Console.ReadLine();

        }
    }
}
