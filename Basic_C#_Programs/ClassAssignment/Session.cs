using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    //declaring static class
    public class Session
    {
        //creating method
        public void Stronghold(int x)
        {
            //whatever the user inputs will be divided by 2
            //and outputted to the screen 
            int z = x / 2;
            Console.WriteLine(z);
            
        }

        //creating method with an output parameter
        public void Fineas(out int y)
        {
            int t = 2;
            y = t; 
        }

        public static int Stronghold(int a , int b=1)
        {
            int c = a + 3;
            int d = c + b;
            return d; 
            
        }
    }

    //declaring static class
    static class Harold
    {
        //static variables
        public static string name;
        public static string country;
        public static int age; 

        public static void Human()
        {
            Console.WriteLine("Human Nature");
        }


    }
}
