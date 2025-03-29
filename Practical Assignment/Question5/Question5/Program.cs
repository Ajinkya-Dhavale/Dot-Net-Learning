using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main()
    {
        Animal myDog = new Dog();
        myDog.Sound(); // Calls Dog's Sound()

        Animal myCat = new Cat();
        myCat.Sound(); // Calls Cat's Sound()

        Animal animal = new Animal();
        animal.Sound(); // Calls Animal's Sound()
    }
}
