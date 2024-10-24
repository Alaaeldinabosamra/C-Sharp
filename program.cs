using System;
using System.IO;
using PartialClasses;
/*
    Partial Classes in C# 
    it is possible to split the definition of a class, a struct, an interface or a method over two or more source files.
    Each source file contains a section of the type or method definition, and all parts are combined when the application is compiled

    why partial classes
    1. when working on large projects, spreading a class over sperate files enables multiple programmers to work on it at the same time
    2. when working with automatically generated source, code can be added to the class without having to recreate the source file
    3. when using source generators to generate additional functionality in a class

*/
// to compile multiple files in Linux ubuntu
// mcs -out:program.exe program.cs EmployeeProps.cs EmployeeMethods.cs
// mono program.exe

public class App{

 public static void Main()
    {
        System.Console.WriteLine("Partial Classess");
        
        Employee newEmployee = new Employee();
        newEmployee.SetEmployeeDetails("John Doe", 30);
        newEmployee.DisplayInfo();
        
    }    
   
}

