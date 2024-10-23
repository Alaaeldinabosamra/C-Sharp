using System;
using System.IO;

/*
    Inheritance => is a mechanism in which one class acquires the property of another class
    a child inherits the traits of his/er parents.
    with inheritance we can reuse the fields and methods of the existing class
*/

public class App{

    public static void Main(){
        Animal animal = new Animal();
        animal.FeedAnimal();

        Dog germenSherpard = new Dog();
        germenSherpard.WalkDog();
        germenSherpard.FeedAnimal();
       
    }

   
}

class Dog : Animal
{
    public string DogBreed {get; set;}
    public string DogIntelligence {get; set;}
    public int EasyToTrainLevel {get; set;}

    public void WalkDog() {}
    public void TrainDog() {}
}

class Bird : Animal{
    public string BirdColor {get; set;}
    public double Altitude {get; set;}

    public void Fly() {}
}


class Animal
{
    public string AnimalName {get; set;}
    public DateOnly AnimalBirthDate {get; set;}

    public void FeedAnimal(
        
    )
}