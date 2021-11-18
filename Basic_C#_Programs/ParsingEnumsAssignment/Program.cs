using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            //prompting user to enter in current week day
            Console.WriteLine("Enter the current day of the week");
            string day = "";
            //parsing 
            // DayOfWeek dayofweek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day); 

          //reads user input 
            string value = Console.ReadLine();  
            try
            {
                DayOfWeek dayofweek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), value);
            }
            catch (Exception ex)
            {
                //only displays if a day of the week is not entered
                Console.WriteLine("Please enter an actual day of the week");
            }
            finally
            {
                Console.ReadLine();
            }


        }

    }
}
