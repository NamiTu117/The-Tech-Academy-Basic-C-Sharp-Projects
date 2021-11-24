using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking user for input 
            Console.WriteLine("Type in a number");
            int numb = Convert.ToInt32(Console.ReadLine());//converts int
            //converting int to string 
            string s;
            s = numb.ToString();
            //writes number to file         
            File.WriteAllText(@"E:\GitHubs\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs\number.txt", s);
            Console.WriteLine(s);

            //printing out results 





        }
    }
}
