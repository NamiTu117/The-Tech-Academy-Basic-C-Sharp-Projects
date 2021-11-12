using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating class
            Scare scare = new Scare();
            
            
            //calling method passing in two numbers 
            scare.Jack(9, 1);
            scare.Jack(x:9, y:1);


        }
    }
}
