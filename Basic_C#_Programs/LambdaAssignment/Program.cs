using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //employee list with names and ids
            Employee employee = new Employee();
            List<Employee> Names = new List<Employee> {
                new Employee{ID=1, EmpName=  "Joe Kemp"},
                new Employee{ID=2, EmpName= "Malena Skye"},
                new Employee {ID=3, EmpName= "Trevor Goodchild"},
                new Employee {ID=4, EmpName = "Raven Rothschild"},
                new Employee{ID=5, EmpName=  "Joe Ryder"},
                new Employee{ID=6, EmpName= "Mirai Takuchi"},
                new Employee {ID=7, EmpName= "Belle Abe"},
                new Employee {ID=8, EmpName = "Ursa Strong"},
                new Employee {ID=9, EmpName = "Major Enu"},
                new Employee {ID=10, EmpName = "Aeon Flux"}

            };


            //making new list to print out Employees with first name Joe 
            List<string> JoeList = new List<string>();
            //foreach loop to iterate and pic
            foreach (Employee j in Names)
            {
                if (j.EmpName == "Joe")
                {
                    
                    JoeList.Add(j.EmpName);
                    Console.WriteLine(j.EmpName);
                }

                
            }

           
            //lambda list to print out Joe names 
            List<Employee> newList1 = Names.Where(x=> x.EmpName == "Joe").ToList();
            Console.WriteLine(newList1);

            //lambda list to print out employees w/ IDs more than 5
            List<Employee> newList2 = Names.Where(x=> x.ID > 5).ToList();
            Console.WriteLine(newList2);


        }

    }
}
