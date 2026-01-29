using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _31_40.Interface
{
    public class MethodImplementation : IMethods, IMethods2
    {
        public void Method1()
        {
            Console.WriteLine("Method1 implementation");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 implementation");
        }

        public void Method3()
        {
            Console.WriteLine("Interface 3");
        }

        public void Method4()
        {
            Console.WriteLine("Interface 4");
        }
    }
}
