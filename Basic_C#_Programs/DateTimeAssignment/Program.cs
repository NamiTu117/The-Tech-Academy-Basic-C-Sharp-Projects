using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //getting current date and time
            DateTime local = DateTime.Now;
            Console.WriteLine(local); //prints out current date and time 

            //prompts user to enter number 
            Console.WriteLine("Please type in a number");
            int numb = Convert.ToInt32(Console.ReadLine());

            //takes current time to see what time it'll be in 
            //in the number of hours the user has put in
            DateTime currentTime = DateTime.Now;
            DateTime HrsLater = currentTime.AddHours(numb);
            Console.WriteLine("It will be {0} in exactly {1} hours",HrsLater, numb);

            


            Console.ReadLine();
        }
    }
}
