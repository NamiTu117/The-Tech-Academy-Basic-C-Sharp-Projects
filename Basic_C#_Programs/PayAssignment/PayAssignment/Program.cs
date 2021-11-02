using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //title prompt
            Console.WriteLine("Anonymous Income Comparison Program\n");
            Console.ReadLine();

            //ask user for person 1's input; hourly rate and hours worked
            Console.WriteLine("Person 1 ");
            Console.WriteLine("\nEnter your hourly rate");
            int hourRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hour Rate: " + hourRate);

            Console.WriteLine("\nEnter the hours you've worked ");
            int hourWork = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week: " + hourWork);

            //total of hours worked and rate
            int total = hourRate * hourWork * 52;
            Console.WriteLine("Annual Salary of Person 1: " + total);
            Console.ReadLine();


            //prompts user to enter person 2's rate and hours worked 
            Console.WriteLine("Person 2 ");
            Console.WriteLine("\nEnter your hourly rate");
            int hourRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hour Rate: " + hourRate2);

            Console.WriteLine("\nEnter the hours you've worked ");
            int hourWork2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week: " + hourWork2);

            int total2 = hourRate2 * hourWork2 * 52;
            Console.WriteLine("Annual Salary of Person 1: " + total2);
            Console.ReadLine();


            //to see if person 1 gets paid more than person 2
            Console.WriteLine("Does Person 1 Make More Than Person 2?");
            bool answer = total > total2;
            Console.WriteLine(answer); 
            Console.ReadLine(); 



        }
    }
}
