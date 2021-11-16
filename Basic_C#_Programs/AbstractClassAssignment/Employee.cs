using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //inheriting Person class 
    class Employee: Person, IQuittable
    {
        //implementing SayName method
        public void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public void Quit(Employee employee)
        {
            Console.WriteLine("I'm putting in my two weeks notice");
        }

        
    }
}
