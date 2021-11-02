using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplicationAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //m
            Console.WriteLine("Enter a number so we can multiply it!");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number is " + num * 50);
            Console.ReadLine();

            //add
            Console.WriteLine("Enter a number so we can add it!");
            int add = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number is " + add + 25);
            Console.ReadLine();

            //divide
            Console.WriteLine("Enter a number so we can divide it!");
            int divide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number is " + divide / 12.5);
            Console.ReadLine();


            //remainder 
            Console.WriteLine("Enter a number so we can get the remainder!");
            int truce = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number is " + truce % 7);
            Console.ReadLine();

            //boolean value equal or less than
            Console.WriteLine("Enter a number so we can known if it's equal or less than 50!");
            int mod = Convert.ToInt32(Console.ReadLine());
            bool number = mod <= 50; 
            Console.ReadLine();









        }
    }
}
