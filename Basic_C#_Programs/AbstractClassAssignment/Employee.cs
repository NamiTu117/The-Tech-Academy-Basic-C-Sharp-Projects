using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //inheriting Person class 
    class Employee: Person 
    {
        //implementing SayName method
        public void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
