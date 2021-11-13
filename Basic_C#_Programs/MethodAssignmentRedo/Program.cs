using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignmentRedo
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodMan methodman = new MethodMan(); 

            //prompts user to input two numbers or just one
            Console.WriteLine("Enter two numbers one at a time, but you don't need to enter anything for the second number");
            int nums = Convert.ToInt32(Console.ReadLine()); //converts input into integer
            try
            {
                int nums2 = Convert.ToInt32(Console.ReadLine());
                int result = methodman.Vibe(nums, nums2); //takes number(s) to print out result
                Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                int result = methodman.Vibe(nums);
                Console.WriteLine(result);
            }
            

            
            

            Console.ReadLine();
        }
    }
}
