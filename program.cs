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

    roles
    1. the source file name can be different, 
    but each partial class's name must be the same.

    2. All the partial class definitions
    must be in the same namespace and assembly.

    3. Must have the same access modifiers like public or private

    4. If any part is declared abstract, sealed or base type
    then the whole class is declared of the same type.

    5. Different parts can have different base types
    so the final class will inherit all the base types.

    6. Must contain the partial keyword

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

/*
Partial Class Definition: Both Employee.cs and EmployeeDetails.cs define parts of the Employee class.

Same Namespace: Both files are in the PartialClasses namespace, allowing the C# compiler to merge them into a single class.

Functionality: In your Main method, you can create an Employee instance, set details, and display them using methods defined across the partial class.

*/
