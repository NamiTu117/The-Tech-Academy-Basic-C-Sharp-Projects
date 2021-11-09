using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception Handling 

            try
            {
                Console.WriteLine("Pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nPick a second number");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nDividing the two..");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex) //ex is datatype format exception 
            {
                Console.WriteLine(ex.Message);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\nPlease don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
            finally
            {

            }
            Console.ReadLine(); 
        }
    }
}
