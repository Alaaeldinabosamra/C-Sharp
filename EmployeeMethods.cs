using System;

// namespace PartialClasses
// {
//     internal partial class Employee
//     {
//         public Employee()
//         {
//             System.Console.WriteLine("Object is created!");
//         }

//         public void DisplayTimesheet()
//         {

//         }

//         public decimal CalculateSalary()
//         {
//             return 1500;
//         }

//     }
// }


namespace PartialClasses
{
    public partial class Employee
    {
        public void SetEmployeeDetails(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}