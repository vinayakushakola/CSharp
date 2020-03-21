using OOPs._2._StaticAndInstance;
using OOPs._3._inheritance;
using OOPs._4._MethodHididng;
using OOPs._5._Polymorphism;
using System;

namespace OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            //..........1.Class...........
            Customer1 C1 = new Customer1("Vinayak", "Ushakola");
            C1.PrintFullName();

            //Customer2 C2 = new Customer2();
            //C2.PrintFullName();
            //Customer2 C3 = new Customer2("Vinayak", "Ushakola");
            //C3.PrintFullName();

            //..........2.Static and Instance.........
            //Circle C = new Circle(5);
            //float area = C.Area();
            //Console.WriteLine("Area: " + area);
            //Circle C2 = new Circle(6);
            //float area2 = C2.Area();
            //Console.WriteLine("Area: " + area2);

            //Circle2 C3 = new Circle2(5);
            //float area3 = C3.Area();
            //Console.WriteLine("Area: " + area3);
            //Circle2 C4 = new Circle2(6);
            //float area4 = C4.Area();
            //Console.WriteLine("Area: " + area4);

            //Circle3 C5 = new Circle3(5);
            //float area5 = C5.Area();
            //Console.WriteLine("Area: " + area5);
            //Circle3 C6 = new Circle3(6);
            //float area6 = C6.Area();
            //Console.WriteLine("Area: " + area6);

            //FullTimeEmployee FTE = new FullTimeEmployee();
            //FTE.FirstName = "Vinayak";
            //FTE.LastName = "Ushakola";
            //FTE.YearlySalary = 5000000;
            //FTE.PrintFullName();

            //Inheritance
            //ChildClass CC = new ChildClass();

            //Method Hiding
            //PartTimeEmployee2 CC2 = new PartTimeEmployee2();
            //CC2.FirstName = "Vin";
            //CC2.LastName = "ush";
            //CC2.PrintFullName();

            //PartTimeEmployee2 CC2 = new PartTimeEmployee2();
            //CC2.FirstName = "Vin";
            //CC2.LastName = "ush";
            //To call same method from parent class
            //((Employee2)CC2).PrintFullName();

            //Employee2 CC2 = new PartTimeEmployee2();
            //CC2.FirstName = "Vin";
            //CC2.LastName = "ush";
            //CC2.PrintFullName();

            //School s = new School();
            //s.PrintName();
            //School s2 = new School("Vinayak", "Ushakola");
            //s2.PrintName();

            //Employee3[] employees = new Employee3[4];
            //employees[0] = new Employee3();
            //employees[1] = new FullTimeEmployee3();
            //employees[2] = new PartTimeEmployee3();
            //employees[3] = new TemporaryEmployee3();

            //foreach (Employee3 e in employees)
            //{
            //    e.PrintFullName();
            //}

            //Employee3 E1 = new Employee3();
            //E1.PrintFullName();
            //Employee3 E2 = new FullTimeEmployee3();
            //E2.PrintFullName();
            //Employee3 E3 = new PartTimeEmployee3();
            //E3.PrintFullName();
            //Employee3 E4 = new TemporaryEmployee3();
            //E4.PrintFullName();

            //FullTimeEmployee3 E1 = new FullTimeEmployee3();
            //E1.PrintFullName();

            //PartTimeEmployee2 ee = new PartTimeEmployee2();
            //ee.PrintFullName();



        }
    }
}
