using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            List<Department> departments = new List<Department>();

            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                List<string> command = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();

                string emplyeeName = command[0];
                string employeeDepartment = command[2];
                double emploeeSalary = double.Parse(command[1]);

                Employee emplyee = new Employee(emplyeeName, employeeDepartment, emploeeSalary);
                employees.Add(emplyee);

                if (!departments.Any(x => x.DepartmanetName == employeeDepartment))
                {
                    Department department = new Department(employeeDepartment, 1, emploeeSalary);
                    departments.Add(department);
                }
                else
                {
                    for(int h=0; h<departments.Count; h++)
                    {
                        if(departments[h].DepartmanetName == employeeDepartment)
                        {
                            departments[h].DepartmentCount++;
                            departments[h].DepartmentSalary += emploeeSalary;
                        }
                    }
                }


            }

            double DepSAR = departments.Max(x => x.DepartmentSalary / x.DepartmentCount);

            string DepName = String.Empty;

            foreach (var val in departments.OrderByDescending(x => x.DepartmentSalary / x.DepartmentCount))
            {
                if((val.DepartmentSalary / val.DepartmentCount) == DepSAR)
                {
                    DepName = val.DepartmanetName;
                }                
            }

            Console.WriteLine($"Highest Average Salary: {DepName}");
            
            foreach (var val in employees.Where(x => x.EmployeeDepartment == DepName).OrderByDescending(y => y.EmployeeSalary))
            {
                Console.WriteLine($"{val.EmployeeName} {(val.EmployeeSalary):f2}");
            }
            
        }

    }



    class Employee
    {
        public Employee(string employeeName, string employeeDepartment, double employeeSalary)
        {
            EmployeeName = employeeName;
            EmployeeDepartment = employeeDepartment;
            EmployeeSalary = employeeSalary;
        }

        public string EmployeeName { get; set; }

        public string EmployeeDepartment { get; set; }

        public double EmployeeSalary { get; set; }
    }



    class Department
    {
        public Department(string departmanetName, int departmentCount, double departmentSalary)
        {
            DepartmanetName = departmanetName;
            DepartmentCount = departmentCount;
            DepartmentSalary = departmentSalary;
        }

        public string DepartmanetName { get; set; }

        public int DepartmentCount { get; set; }

        public double DepartmentSalary { get; set; }
    }



}
