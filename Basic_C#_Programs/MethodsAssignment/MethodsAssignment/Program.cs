using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks user to enter a number to add, subtract, and multiply with 
            Console.WriteLine("What number do you want to do math operations on?");
            int choice = Convert.ToInt32(Console.ReadLine()); //converts input to integer
            //entered number (choice) is ran through functions to display results 
            Console.WriteLine("Your number + 10 is: " + Math.Addition(choice));
            Console.WriteLine("Your number - 8 is: " + Math.Subtraction(choice));
            Console.WriteLine("Your number * 5 is: " + Math.Multiplication(choice));
            Console.ReadLine();

           
        }
        
    }
}
