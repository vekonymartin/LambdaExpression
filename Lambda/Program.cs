using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logging("log.txt", "Hello Delegat World!");
            Log.Numbers(100);
        }
    }
}
