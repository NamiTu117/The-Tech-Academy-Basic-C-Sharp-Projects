using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompts user to enter their age
            //if the user is 15 years old or older, they qualify for insurance
            Console.WriteLine("What is your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            //prompts user to enter true or false 
            // if the user enters false, they don't qualify for insurance
            Console.WriteLine("Have you ever had a DUI? Answer true or false");
            bool answer = Convert.ToBoolean(Console.ReadLine()); 
            Console.ReadLine();


            //prompts user to enter an amount of speeding tickets
            //if user has 3 or less, they qualify for insurance
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            //takes user data and prints out a true or false
            //If they meet the requirements for insurance
            Console.WriteLine("Qualify for Insurance?"); 
            bool quality = (age >= 15 && answer == true && tickets <= 3);
            Console.WriteLine(quality);
            Console.ReadLine(); 



        }
    }
}
