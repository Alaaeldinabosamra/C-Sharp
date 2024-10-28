using System;
using System.IO;

/*
    Structs in C# 
    A struct type(or structure type) is a value type that can encapsulate data and related functionallity    
*/
// to compile multiple files in Linux ubuntu
// mcs -out:program.exe program.cs EmployeeProps.cs EmployeeMethods.cs
// mono program.exe

public class App{

 public static void Main()
    {
    Employee newEmployee = new Employee();
    newEmployee.EmployeeName = "John";
    newEmployee.EmployeeJob = "Lawyer";
    newEmployee.Salary = 8000;
    System.Console.WriteLine($"Employee name is : {newEmployee.EmployeeName}");
    System.Console.WriteLine($"Employee job is : {newEmployee.EmployeeJob}");
    System.Console.WriteLine($"Employee salary is : {newEmployee.Salary}");
    newEmployee.DisplayTimesheet();
    Console.ReadLine();
    
    }    
   
}

public struct Employee
{
    public string EmployeeName {get; set;}
    public string EmployeeJob {get; set;}
    public decimal Salary {get; set;}
    // // parameterless constructor => work in some versions not all
    // public Employee()
    // {
    //     System.Console.WriteLine("hello from non-parameter constructor");
    // }
    // parameterized constructor
    public Employee(string name, string job, decimal salary)
    {
        EmployeeName = name;
        EmployeeJob = job;
        Salary = salary;
    }

    public void DisplayTimesheet()
    {
        System.Console.WriteLine("Timesheet method in struct");
    }
}