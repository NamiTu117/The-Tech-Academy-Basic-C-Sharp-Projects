using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparison.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Five minus Ten = " + difference.ToString());
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrflase = 12 < 5;
            //Console.Write(trueOrflase.ToString());
            //Console.ReadLine();
            //Console.ReadLine();s

            //comparisons
            int roomTempearture = 70;
            int currentTemperature = 70;

            //bool isWarm = currentTemperature <= roomTempearture;
            bool isWarm = currentTemperature == roomTempearture;
            Console.WriteLine(isWarm);
            Console.ReadLine();

        }
    }
}
