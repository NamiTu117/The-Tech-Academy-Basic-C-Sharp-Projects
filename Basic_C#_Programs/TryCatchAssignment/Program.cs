using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //prompting user to enter their age
                Console.WriteLine("Hi there! Please enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age == 0 || age < 0)
                {
                    Console.WriteLine("You cannot enter a zero or a negative number");
                    return;
                }
                DateTime currentYear = DateTime.Now;
                //turning data into a string to later convert into an integer
                string year = currentYear.Year.ToString();
                int ano = Convert.ToInt32(year);
                int old = ano - age;
                Console.WriteLine("You were born in {0}", old);
            
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.ReadLine();
            }











        }
        }   
}
