using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructAssignment
{
    public class Base
    {
        //how to chain a construct

        //properties
        public string ShowName { get; set; }
        public int Channel { get; set; }
        
        //chained constructor
        public Base(string showname) : this(showname, 001)
        {
            Console.WriteLine("{0} on Channel {1}", showname, Channel);
        }

        //constructor
        public Base(string showname, int channel)
        {
            Channel = channel;
            ShowName = showname;
        }

       
    }
}
