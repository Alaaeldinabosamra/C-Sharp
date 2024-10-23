using System;
using System.IO;

/*
    Abstraction in C# تجريد
    is a concept or an idea not associated[غير مرتبطة] with any specific instance
*/

public class App{

 public static void Main()
    {
        System.Console.WriteLine("Abstraction");
        Line line = new Line();
        line.SayHello();
        line.Draw();
        
    }    
   
}

abstract class Person
{
    abstract public void Draw() ;
    public void SayHello()
    {
        System.Console.WriteLine("Hello from the abstract class");
    }
   
}

class Line : Person

{
    public override void Draw()
    {
        System.Console.WriteLine("Hello from Line Person");
    }
}