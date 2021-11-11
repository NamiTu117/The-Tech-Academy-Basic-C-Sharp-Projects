using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Math2
    {
        //creating methods
        public int Multiplication(int y)
        {
            int x = y * 9;
            return x; 
        }

        public int Multiplication(decimal d1)
        {
            //convertng decimal to integer
            int k = Convert.ToInt32(d1);
            int h = k + 8; 
            return h;
        }

        public int Multiplication(string user)
        {
            //converting string to integer
            int t = Convert.ToInt32(user);
            int y = t + 9;
            return y; 

            

             

            
        }
    }
}
