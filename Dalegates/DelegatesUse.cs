using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_40.Dalegates
{
    //Store refrences of the methods which have same return types and parameters
    public delegate bool isPromote(Employee promotableEmplyoo);
    public class Employee
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public int empAge { get; set; }
        public int empExperiance { get; set; } = 0;


        public static void EmployeePromotion(List<Employee> list, isPromote promoteOrNot)
        {
            foreach(Employee e in list)
            {
                if (promoteOrNot(e))
                {
                    Console.WriteLine($"{e.empName} are promoted");
                }
            }
        }
    }
}
