using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodandObjectAssignment
{
    //creating class
    public class Person
    {
        //giving Person two properties 
        string FirstName { get; set; }
        string LastName { get; set; }

        //creating method where the First and Last name are displaye
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName); 
        }
    }
}
