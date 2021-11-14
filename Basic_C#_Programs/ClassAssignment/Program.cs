using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating class 
            Session session = new Session();

            //prompting user to enter an integer
            Console.WriteLine("Enter a number");
            int cat = Convert.ToInt32(Console.ReadLine());
            session.Stronghold(cat);

            //output parameter
            int b = 50; 
            session.Fineas(out b);

            //overload method 
            int kitten = 6;
            session.Stronghold(kitten) ; 


            Console.ReadLine();

            //static outputs 
            Harold.name = "Dwight";
            Harold.country = "Japan";
            Harold.age = 20;

            //static class display results
            Console.WriteLine("{0}", Harold.name);
            Console.WriteLine("{0}", Harold.country);
            Console.WriteLine("{0}", Harold.age);
            Harold.Human();

            Console.ReadLine();




        }
    }
}
