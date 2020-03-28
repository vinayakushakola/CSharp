using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.PrototypeDesignPattern
{
    class Employee
    {
        private List<string> employeeList;

        public Employee()
        {
            employeeList = new List<string>();
        }

        public Employee(List<string> employee)
        {
            employeeList = employee;
        }

        public void LoadEmployee()
        {
            for (int i=1; i<5; i++)
            {
                employeeList.Add("Emp " + i);
            }
        }

        public List<string> GetEmpData()
        {
            return employeeList;
        }

        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }
    }
}
