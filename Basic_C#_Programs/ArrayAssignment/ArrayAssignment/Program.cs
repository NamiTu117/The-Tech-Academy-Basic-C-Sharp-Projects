using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] stringArray = { "Raven", "BeastBoy", "Terra", "Starfire", "Robin" };
            Console.WriteLine("Select an index from the array");
            string element = Console.ReadLine(); 
            Console.ReadLine();


            int[] intArray = { 60, 1, 0, 9, 431 };
            Console.WriteLine("Select an index from the array");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();


            if (element != stringArray || numbers != intArray)
            {
                Console.WriteLine("The element(s) you've entered cannot be found!");
            }
            



        }
    }
}
