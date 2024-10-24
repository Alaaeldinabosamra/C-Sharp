using System;
using System.IO;

/*
    Sealed Classes in C# 
    are used to restrict the inheritance.
    once a class is defined as a sealed class this class cannot be inherited
*/

public class App{

 public static void Main()
    {
        System.Console.WriteLine("Sealed Classess");
        Animal animal1 = new Animal();
       
        
    }    
   
}

// sealed you close class from inherted
sealed class Animal{
    public string Name {get; set;}
    public Animal () 
    {
        System.Console.WriteLine("Hello from constructor method");
    }
}

class Dog {
    public string DogBreed {get; set;}
}