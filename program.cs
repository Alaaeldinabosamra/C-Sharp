/*
static methods
A static function, unlike a regular(instance) function, is not associated (مش مرتبطة) with an instance of the class
static methods are called by using the class name, not the instance of the class 
like console class and it read and write methods are an example of static methods
*/
using System;
public class Program
{
    public static void Main(string[] args)
    {
        Bank.CreateNewAccount(); //appear without make instance of the class

        Bank account = new Bank();
        account.createNewAccountNotStatic(); // appear after making instance of the class
        Console.ReadLine();
        
    }
}

class Bank
{
    public static void CreateNewAccount()
    {
        System.Console.WriteLine("New account has been created using static method");
    }

    public void createNewAccountNotStatic()
    {
        System.Console.WriteLine("New account has been created using non static method");
    }
}