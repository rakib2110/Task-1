using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
namespace Task_1
{
    //public Link(System.Collections.Generic.IEnumerable<T> source);
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public string Dob { get; set; }
        public string Doj { get; set; }
        public string BloodGroup { get; set; }
        public int DepartmentId { get; set; }
        public bool IsAcvtive { get; set; }
        //    public Employee(int id, string name, int code, string dob, string doj, string bd, int d_id, bool active)
        //    {
        //this.Id = id;
        //        this.Name = name;
        //            this.Code = code;
        //            this.Dob = dob;
        //            this.Doj = doj;
        //        this.BloodGroup = bd;
        //            this.DepartmentId = d_id;
        //        this.IsAcvtive = active;
        //    }
        public void display()
        {
            Console.WriteLine($"Id:{Id},Name:{Name},Code:{Code},Dob:{Dob},Doj:{Doj},Blood Group:{BloodGroup},DepartmentId: {DepartmentId},IsActive:{IsAcvtive}");
        }

    }
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool IsActive { get; set; }
        public void display()
        {
            Console.WriteLine($"DepartmentId:{DepartmentId},DepartmentName:{DepartmentName},IsActive:{IsActive}");
        }

    }
    class Test()
    {
        public static void Main(string[] args)
        {
             int id;
             string name;
             int code;
             string dob;
             string doj;
             string bd;
             int d_id;
             string d_name;
             bool active;

            Console.WriteLine("Enter the amount of Employee: ");
            int num = Convert.ToInt32(Console.ReadLine());
             List<Employee> employees = new List<Employee>();
             List<Department> departments = new List<Department>();
            try
            {
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine($"For Employee: {i}");
                    Console.Write("Enter the Employee Id: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the Employee Name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter the Employee Code: ");
                    code = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the Employee Date of birth: ");
                    dob = Console.ReadLine();
                    Console.Write("Enter the Employee Date of join: ");
                    doj = Console.ReadLine();
                    Console.Write("Enter the Employee Blood Group: ");
                    bd = Console.ReadLine();
                    Console.Write("Enter the  Department Id: ");
                    d_id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the Department Name: ");
                    d_name = Console.ReadLine();
                    active = true;

                    Employee EE = new Employee()
                    {
                        Id = id,
                        Name = name,
                        Code = code,
                        Dob = dob,
                        Doj = doj,
                        BloodGroup = bd,
                        DepartmentId = d_id,
                        IsAcvtive = active,


                    };
                    Department RR = new Department()
                    {
                        DepartmentId = d_id,
                        DepartmentName = d_name,
                        IsActive = active,

                    };
                    employees.Add(EE);
                    departments.Add(RR);

                    for (int j = 1; j <= employees.Count; j++)
                    {
                        Console.Write($"Employee Details:{j+1}");
                        Employee employee = employees[j];
                        employee.display();
                        Department department = departments[j];
                        department.display();
                    }
                }

                // Employee list = new Employee(int id,string name,int code,string dob,string doj,string bd,int d_id,bool active);
                //list.display();
                ////Department departmentList = newDepartment(int d_id,string d_name,bool active);
                //departmentList.display();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
