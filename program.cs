using System;
using System.IO;

public class App{

    public static void Main(){
        int number = 10;
        System.Console.WriteLine("Non recursive way");
        System.Console.WriteLine(Factorial(number));
        System.Console.WriteLine("Recursive way");
        System.Console.WriteLine(FactorialRecursion(number));

        string path = string.Empty;
        path = "/home/alaaeldin/Coding/films";

        System.Console.WriteLine(path);
        DisplayFolders(path, 0);

        System.Console.WriteLine($"{new string(' ', 3)}alaa" );
    }

    static int Factorial(int number)
    {
        if(number == 0)
            return 1;
        int value = 1;
        for(int i = number; i > 0; i--)
        {
            value = value * i;
            System.Console.WriteLine(i);
        }
        return value;
    }
    static int FactorialRecursion(int number){
        if(number == 0)
            return 1;
        return number * FactorialRecursion(number - 1);
    }

    static void DisplayFolders(string path, int indent)
    {
     foreach (var folder in Directory.GetDirectories(path))
     {
        System.Console.WriteLine($"{new string(' ',indent)} {Path.GetFileName(folder)}");
        DisplayFolders(folder, indent + 1);
     }   
    }
}