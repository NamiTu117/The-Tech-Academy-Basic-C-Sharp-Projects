using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop 
            int a = 12; 
            while (a > 1)
            {
                Console.WriteLine(a);
                a--;
                Console.ReadLine(); 
            }

            //do while loop
            int b = 3;
            do
            {
                //b is 3. with b++, it will count upwards 3 times
                Console.WriteLine(b);
                b++;
            }
            while (b < 4);
            Console.ReadLine();


        }
    }
}
