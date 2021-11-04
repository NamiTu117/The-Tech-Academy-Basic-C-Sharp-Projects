using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name!");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (name == "Tadashi" && age >= 21) 
            {
                Console.WriteLine("Hi Tadashi! You're a big boy");
                Console.ReadLine(); 
            }
            else 
            {
                Console.WriteLine("Hi! " + name + "Take a seat!");
                Console.ReadLine();
            }
    }
}
