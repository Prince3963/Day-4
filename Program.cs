using System.Drawing;
using _31_40.Dalegates;
using _31_40.Interface;
public class Program
{
    private static void Main(string[] args)
    {
        //MethodImplementation implementation = new MethodImplementation();
        //implementation.Method1();
        //implementation.Method2();
        //implementation.Method3();
        //implementation.Method4();

        paragImplementation parag = new paragImplementation();
        parag.paragStipend();
        parag.paranName();

        Abstract @abstract = new Abstract();
        @abstract.paragDemo();

        //dalegateFunctions d = new dalegateFunctions(Dalegate.Hello);
        //d("Hello from Delegate");


        //Point p1 = new Point { X = 10, Y = 20 };
        //Point p2 = p1;   // COPY

        ////p1.X = 50;
        //p2.X = 99;

        //Console.WriteLine(p1.X); // 👉 10 (unchanged)
        //Console.WriteLine(p1.Y); // 👉 10 (unchanged)
        //Console.WriteLine(p2.X); // 👉 10 (unchanged)
        //Console.WriteLine(p2.Y); // 👉 10 (unchanged)
    }
}