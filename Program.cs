using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using _31_40.Dalegates;
using _31_40.Interface;
public class Program
{

    //Method for Experiance
    public static bool PromoteEmp(Employee emp)
    {
        if (emp.empExperiance >= 5)
        {
            return true;
        }
        return false;
    }

    //Method for Age
    public static bool PromoteAge(Employee emp)
    {
        if (emp.empAge >= 25)
        {
            return true;
        }
        return false;
    }

    //Method for Age and Experiance
    public static bool PromoteAgeAndExperiance(Employee emp)
    {
        if (emp.empAge >= 24 && emp.empExperiance >= 4)
        {
            return true;
        }
        return false;
    }

    private static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { empId = 1, empName = "Jem", empAge = 21, empExperiance = 3 },
            new Employee { empId = 2, empName = "Rahul", empAge = 29, empExperiance = 6 },
            new Employee { empId = 3, empName = "Neel", empAge = 22, empExperiance = 5 },
            new Employee { empId = 4, empName = "Ronak", empAge = 21, empExperiance = 3 },
            new Employee { empId = 5, empName = "Himanshu", empAge = 24, empExperiance = 4 },
            new Employee { empId = 6, empName = "Prince", empAge = 25, empExperiance =  6},
        };


        // Experiance Delegate
        Console.WriteLine("Promotion based on Experiance:");
        isPromote promote = new isPromote(PromoteEmp);
        Employee.EmployeePromotion(employees, promote);

        Console.WriteLine("---------------------------");

        // Age Delegate
        Console.WriteLine("Promotion based on Age:");
        isPromote promoteAge = new isPromote(PromoteAge);
        Employee.EmployeePromotion(employees, promoteAge);

        Console.WriteLine("---------------------------");

        //Age and Experiance Delegate
        Console.WriteLine("Promotion based on Age and Experiance:");
        isPromote promoteAgeAndExperiance = new isPromote(PromoteAgeAndExperiance);
        Employee.EmployeePromotion(employees, promoteAgeAndExperiance);


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