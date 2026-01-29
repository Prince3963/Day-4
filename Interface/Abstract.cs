using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_40.Interface
{
    public interface IAbstract
    {
        public void paragDemo();
    }
    internal class Abstract : IAbstract
    {
        public void paragDemo()
        {
            Console.WriteLine("Parag Abstract");
        }
    }
}
