using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchAssignment_Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express\n");
            Console.ReadLine();

            Console.WriteLine("Please enter the weight of your package");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(packWeight + "lbs");
            Console.ReadLine();

            if (packWeight > 50)
            {
                Console.WriteLine("\nPackage to heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine(); 

            }
            else
            {
                Console.WriteLine("\nPlease enter the width of your package");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

                Console.WriteLine("\nPlease enter the height of your package");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

                Console.WriteLine("\nPlease enter the length of your package");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

                int dimension = width +  height + length; 
                if ( dimension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine(); 
                }
                else
                {

                    int dimensions = width * height * length;
                    int total = dimensions * packWeight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is " + "$" + total);
                    Console.ReadLine();  



                }
            }
                
           

        }
    }
}
