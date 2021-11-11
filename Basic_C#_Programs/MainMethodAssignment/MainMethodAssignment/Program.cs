using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating class
            Math2 math2 = new Math2(); 

            //displaying results 
            int choice = 8;            
            int product = math2.Multiplication(choice);
            Console.WriteLine(product);

            //returning decimal as integer
            decimal choice2 = 60m;
            int result = math2.Multiplication(choice2);
            Console.WriteLine(result);

            //returning string as integer
            string choice3 = "9"; 
            int results = math2.Multiplication(choice3);
            Console.WriteLine(results);
            
            


            Console.ReadLine();
        }

    }
}
