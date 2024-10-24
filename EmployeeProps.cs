using System;

// namespace PartialClasses
// {
//     internal partial class Employee
//     {
//         public int EmployeeNumber {get; set;}
//         public string EmployeeName {get; set;}
//         public string EmployeeJob {get; set;}

//     }
// }

namespace PartialClasses
{
    public partial class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public void DisplayInfo()
        {
            System.Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}