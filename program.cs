/*
Extensions methods
adding custom methods with methods in C#
*/
using System;
public class Program
{
    public static void Main(string[] args)
    {
       string WelocmeMessage = "Hello and welcome to my profile";
       System.Console.WriteLine(WelocmeMessage.Length);
       System.Console.WriteLine(WelocmeMessage.CountWords());

       int x = 5;
       System.Console.WriteLine(x.IsGreater(10));

       string text = "500";
       System.Console.WriteLine(text.IsNumber());
        
    }
}

static class ExtensionsMethods
{
    public static bool IsGreater(this int no1, int no2)
    {
        return no1 > no2;
    }

    public static bool IsNumber(this string text)
    {
        return int.TryParse(text, out int n);
    }

    public static int CountWords(this string statement)
    {
        if(!string.IsNullOrEmpty(statement))
        {
            string[] stringArray = statement.Split(' ');
            return stringArray.Length;
        }
        else
            return 0;
    }
}