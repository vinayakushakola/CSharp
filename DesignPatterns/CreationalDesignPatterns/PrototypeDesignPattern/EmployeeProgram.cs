using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.PrototypeDesignPattern
{
    class EmployeeProgram
    {
        public static void EmployeeRun()
        {
            try
            {
                Console.WriteLine("Output: ");
                Employee employee = new Employee();
                employee.LoadEmployee();

                Employee employee1 = employee.ShallowCopy();

                Employee employee2 = employee.ShallowCopy();


                List<string> empList = employee.GetEmpData();
                foreach(String data in empList)
                {
                    Console.Write(data + " ");
                }
                Console.WriteLine();

                List<string> empList1 = employee.GetEmpData();
                empList1.Add("Vinayak");
                foreach (String data in empList1)
                {
                    Console.Write(data + " ");
                }
                Console.WriteLine();


                List<string> empList2 = employee.GetEmpData();
                empList2.Remove("Vinayak");
                empList2.Remove("Emp 4");

                foreach (String data in empList2)
                {
                    Console.Write(data + " ");
                }
                Console.WriteLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }
    }
}
