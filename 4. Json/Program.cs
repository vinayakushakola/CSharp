using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("File Reading...");
            Console.WriteLine();
            //Path for reading json file
            string inputPath = @"D:\Github\CSharp\4. Json\Data\EmployeeDataReading.json";

            string jsonFileReading = File.ReadAllText(inputPath);

            EmployeeList myData = JsonConvert.DeserializeObject<EmployeeList>(jsonFileReading);

            List<EmployeeData> employeeInfo = myData.EmployeeInfo;
            foreach(EmployeeData data in employeeInfo)
            {
                Console.WriteLine("Name: {0}\nAge: {1}\nDepartment: {2}\nLocation: {3}", data.Name, data.Age, data.Department, data.Location);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("File Saving...");

            //Path for saving json file
            string outputPath = @"D:\Github\CSharp\4. Json\Data\EmployeeDataAdding.json";

            EmployeeData employeeData = new EmployeeData()
            {
                Name = "Sarva",
                Age = 22,
                Department = "Python",
                Location = "Mumbai"
            };
            List<EmployeeData> employeeInformation = new List<EmployeeData>();
            employeeInformation.Add(employeeData);

            EmployeeList employeeList = new EmployeeList()
            {
                EmployeeInfo = employeeInformation
            };

            string employeeJsonData = JsonConvert.SerializeObject(employeeList);

            using (StreamWriter sw = new StreamWriter(outputPath))
                sw.WriteLine(employeeJsonData);
            Console.WriteLine("File Saved Successfully");
        }
    }
}
