using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Employee
    {
        public string FirstNameID { get; set; }
        public string LastNameID { get; set; }

        public int Id { get; set; }

        public void Name()
        {
            Console.WriteLine(FirstNameID + " " + LastNameID);
        }

        //overriding == operator 
        public static bool operator== (Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        public static bool operator!= (Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id; 
        }
    }
}
