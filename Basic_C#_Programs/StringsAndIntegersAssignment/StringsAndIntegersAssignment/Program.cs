using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Nums = new List<int>() { 9, 10, 7, 45, 5, 90 };
            try
            { 

                //initalizing an integer list               
                Console.WriteLine("Enter a number");
                int number = Convert.ToInt32(Console.ReadLine());

                   
                foreach (int num in Nums)
                {
                    //takes the number and divides it by other numbers
                    //on the list
                    int sum = num / number;
                    Console.WriteLine(sum); 

                }
                
            }            
            catch (FormatException ex)
            {
                //Message warning user against using strings
                //an int initialized environment
                Console.WriteLine(ex.Message);
            }
            //this exception gives a warning to not divide by zero 
            catch(DivideByZeroException ex)
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
