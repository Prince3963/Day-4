using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using _31_40.Dalegates;
using _31_40.Interface;
public class Program
{
    public delegate bool isPromote(Employee promotableEmplyoo);

    public class Employee
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public int empAge { get; set; }
        public int empExperiance { get; set; } = 0;


        public static void EmployeePromotion(List<Employee> list, isPromote promoteOrNot)
        {
            foreach (Employee e in list)
            {
                if (promoteOrNot(e))
                {
                    Console.WriteLine($"{e.empName} are promoted");
                }
            }
        }
    }

    public static bool PromoteEmp(Employee emp)
    {
        if (emp.empExperiance >= 5)
        {
            return true;
        }
        return false;
    }


    private static void Main(string[] args)
    {

        List<Employee> employees = new List<Employee>
        {
            new Employee { empId = 1, empName = "Parag", empAge = 21, empExperiance = 3 },
            new Employee { empId = 2, empName = "Rahul", empAge = 29, empExperiance = 6 },
            new Employee { empId = 3, empName = "Neel", empAge = 22, empExperiance = 5 },
        };

        

        isPromote promote = new isPromote(PromoteEmp);

        Employee.EmployeePromotion(employees, promote);




        //MethodImplementation implementation = new MethodImplementation();
        //implementation.Method1();
        //implementation.Method2();
        //implementation.Method3();
        //implementation.Method4();

        //paragImplementation parag = new paragImplementation();
        //parag.paragStipend();
        //parag.paranName();

        //Abstract @abstract = new Abstract();
        //@abstract.paragDemo();

        //dalegateFunctions d = new dalegateFunctions(Dalegate.Hello);
        //d("Hello from Delegate");


        //Point p1 = new Point { X = 10, Y = 20 };
        //Point p2 = p1;   // COPY

        //p1.X = 50;
        //p2.X = 99;

        //Console.WriteLine(p1.X); // 👉 10 (unchanged)
        //Console.WriteLine(p1.Y); // 👉 10 (unchanged)
        //Console.WriteLine(p2.X); // 👉 10 (unchanged)
        //Console.WriteLine(p2.Y); // 👉 10 (unchanged)
    }
}