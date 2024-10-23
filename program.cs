using System;
using System.IO;

/*
    Polymorphism in C#
    polymorphism means having many forms.
    that means a function or an operator behaves differently in different scenarios

    two types of polymorphism
    => compile time (static type) => overloading
    => runtime (dynamic)          => overriding [allow to change the functionality of a method in a child class]

    The use of virtual and override supports runtime polymorphism. When you call a method on a reference of the base class type that points to an instance of a derived class, the overridden method in the derived class will be executed.
*/

public class App{

 public static void Main()
    {
        System.Console.WriteLine("Polymorphism");
        // Shape shape = new Shape();
        // shape.Draw();
        
        // Shape shape1 = new Circle();
        // shape1.Draw();

        Shape[] shapes = new Shape[4];
        shapes[0] = new Shape();
        shapes[1] = new Circle();
        shapes[2] = new Triangle();
        shapes[3] = new Line();

        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }    
   
}


class Shape 
{
    //  virtual => It provides a base implementation that can be overridden by any derived class.
    public virtual void Draw()
    {
        System.Console.WriteLine("Basic Shape is Created!");
    }
}

class Circle : Shape{
    //  override => This allows the derived class to provide its own implementation of the method.
    public override void Draw()
    {
        System.Console.WriteLine("Circle is Created!");
    }
}

class Triangle : Shape{
    public override void Draw()
    {
        System.Console.WriteLine("Triangle is Created!");
    }
}

class Line : Shape
{
    public override void Draw()
    {
        System.Console.WriteLine("Line is Created!");
    }
}