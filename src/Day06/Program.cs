using System;

interface IAnimal
{
    void Sound();
}

abstract class Animal
{
    public abstract void Eat();

    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping");
    }
}

class Dog : Animal, IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Dog barks");
    }

    public override void Eat()
    {
        Console.WriteLine("Dog eats food");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Sound();
        dog.Eat();
        dog.Sleep();
    }
}
