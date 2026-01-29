using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_40.Dalegates
{
    public delegate void dalegateFunctions(string message);
    public class Dalegate
    {
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
