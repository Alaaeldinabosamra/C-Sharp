using System;
using System.IO;

/*
    Static Classes in C# 
    A static class cannot be instantiated. In other words, you cannot use the new operator to create a variable of the class type
    because there is no instance variable, you access the members of a static class by using the clas,name itself
*/

public class App{

 public static void Main()
    {
        System.Console.WriteLine("Static Classess");
        
        System.Console.WriteLine(Company.CompanyName);
        System.Console.WriteLine(Company.CompanyLocation);

        System.Console.WriteLine(Company.GetTotalEmployees());
       /*
            1. only static members allowed
            2. cannot be instantiated
            3. is sealed by default [cannot be inherted]
            4. cannot contain instance constructor
       */
        
    }    
   
}


static class Company{
    static public string CompanyName =  "Samraspace";
    static public string CompanyLocation =  "New Cairo";
    

    static public int GetTotalEmployees()
    {
        return 3850;
    }
}

