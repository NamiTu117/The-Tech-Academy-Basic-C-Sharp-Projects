using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing a string array 
            string[] stringArray = { "Raven", "BeastBoy", "Terra", "Starfire", "Robin" };
            Console.WriteLine("\nSelect an index from the array");
            string element = Console.ReadLine(); 
            Console.ReadLine();


            int[] intArray = { 60, 1, 0, 9, 431 };
            Console.WriteLine("\nSelect an index from the array");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();




            for (int i = 0; i < stringArray.Length; i++)
            {
                if (element != stringArray[i] )
                {
                    Console.WriteLine("\nThe element(s) you've entered cannot be found!");
                    

                }
                else
                {
                    Console.WriteLine("\nItem found at index:" + i);
                }
            }

            for (int a = 0; a < intArray.Length; a++ )
            {
                if (numbers == intArray[a] )
                {
                    Console.WriteLine("\nItem found at index:" + a);
                   
                }
                else
                {
                    Console.WriteLine("Item not found at index:" + a);
                }
                
            }


            List<string> strName = new List<string>();
            Console.WriteLine("\nPlease select an index");
            strName.Add("Duncan");
            strName.Add("Elsa");
            strName.Add("Bart");
            strName.Add("Chelsea");
            string name  = Console.ReadLine();

            for (int k = 0; k < strName.Count; k++)
            {
                if (name == strName[k])
                {
                    Console.WriteLine("You have selected item:" + name);
                }   
            }

            Console.ReadLine();            



        }
    }
}
