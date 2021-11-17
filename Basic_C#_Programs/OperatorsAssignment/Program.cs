using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //instantiating class 
            Employee employee = new Employee();
            employee.FirstNameID = "Danny";
            employee.LastNameID = "Phantom";
            employee.Id = 1;

            //instantiating object/class
            Employee employee2 = new Employee();
            employee2.Id = 1;
            Console.WriteLine(employee != employee2);

            employee.Name();

            
        










        }
    }
    
}
