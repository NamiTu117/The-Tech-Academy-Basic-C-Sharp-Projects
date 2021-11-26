using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructAssignment
{
    class Programs
    {
        static void Main(string[] args)
        {
           
            
            //creating a const string
            const string Greet = "Welcome! Please enter your favorite show";
            Console.WriteLine(Greet);
            string input = Console.ReadLine();

            //using keyword var
            var Show = new Base(input);


           

        }
    }
}
