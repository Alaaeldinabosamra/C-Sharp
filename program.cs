using System;
using System.IO;

/*
    Encapsulation in C#
    => refers to an object's ability to hide data and behavior that are not neccesary to its user.
    it enables a group of properties and methods and other members to considered a single unit or object

    Access Modifiers

    Public : allow a class to expose its members variables and member function to other function and objects
    any public member can be accessed from outside the class

    Private : allow a class to hide its member variables and member functions from other function and objects 
    only function of the same class can access its private members

    protected : allows a child class to access the member variables and member functions of its base class
    this way it helps in implementing inheritance

    Internal : the type or member can be accessed by any code in the same assembly, but not from another assembly
*/

public class App{

 public static void Main()
    {
        System.Console.WriteLine("Encapsulation");
        Dog dog = new Dog();
        
    }    
   
}

class Animal{ 
    // properties - variables

    // Private variable: can only be accessed within the Animal class.
    private string privateVariable;
    // Public variable: can be accessed from anywhere, including outside the Animal class.
    public string publicVariable;
    // Protected variable: can be accessed within the Animal class and by derived classes (child classes).
    protected string protectedVariable;
    // Internal variable: can be accessed by any code in the same assembly, but not from outside the assembly.
    internal string internalVariable;

    // methods - functions
    private void TrainAnimalPrivate() {}
    public void TrainAnimalPublic() { privateVariable }
    protected void TrainAnimalProtected() {}
    internal void TrainAnimalInternal() {}
}


class Dog : Animal
{
    Dog dog1 = new Dog();
    void FeedDog()
    {
        dog1.TrainAnimalProtected()
    }
}

class Cat : Animal
{
    Dog dog2 = new Dog();
    Cat cat1 = new Cat();
    void FeedCat() 
    {
        
    }
}