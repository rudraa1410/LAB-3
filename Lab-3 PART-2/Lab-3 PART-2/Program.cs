using System;
using System.Collections.Generic;
public interface IAnimal
{
    string Name { get; set; }
    string Colour { get; set; }
    int Height { get; set; }
    int Age { get; set; }
    string GetName();
    string GetColour();
    int GetHeight();
    int GetAge();

    void SetName(string name);
    void SetColour(string colour);
    void SetHeight(int height);
    void SetAge(int age);

    void Eat();
    string Cry();
}
public class Dog : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Height { get; set; }
    public int Age { get; set; }
    public string GetName() => Name;
    public string GetColour() => Colour;
    public int GetHeight() => Height;
    public int GetAge() => Age;
    public void SetName(string name) => Name = name;
    public void SetColour(string colour) => Colour = colour;
    public void SetHeight(int height) => Height = height;
    public void SetAge(int age) => Age = age;

    public void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }
    public string Cry()
    {
        return "Woof!";
    }
}
public class Cat : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Height { get; set; }
    public int Age { get; set; }
    public string GetName() => Name;
    public string GetColour() => Colour;
    public int GetHeight() => Height;
    public int GetAge() => Age;
    public void SetName(string name) => Name = name;
    public void SetColour(string colour) => Colour = colour;
    public void SetHeight(int height) => Height = height;
    public void SetAge(int age) => Age = age;
    public void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }
    public string Cry()
    {
        return "Meow!";
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();

        Console.Write("Enter dog name: ");
        myDog.SetName(Console.ReadLine());
        Console.Write("Enter dog height: ");
        myDog.SetHeight(int.Parse(Console.ReadLine()));
        Console.Write("Enter dog colour: ");
        myDog.SetColour(Console.ReadLine());
        Console.Write("Enter dog age: ");
        myDog.SetAge(int.Parse(Console.ReadLine()));
        Console.WriteLine($"Dog Name: {myDog.GetName()}");
        Console.WriteLine($"Dog Height: {myDog.GetHeight()}");
        Console.WriteLine($"Dog Colour: {myDog.GetColour()}");
        Console.WriteLine($"Dog Age: {myDog.GetAge()}");
        myDog.Eat();
        Console.WriteLine($"Dog says: {myDog.Cry()}");
        Cat myCat = new Cat();

       
        Console.Write("Enter cat name: ");
        myCat.SetName(Console.ReadLine());
        Console.Write("Enter cat height: ");
        myCat.SetHeight(int.Parse(Console.ReadLine()));
        Console.Write("Enter cat colour: ");
        myCat.SetColour(Console.ReadLine());
        Console.Write("Enter cat age: ");
        myCat.SetAge(int.Parse(Console.ReadLine()));

        Console.WriteLine($"Cat Name: {myCat.GetName()}");
        Console.WriteLine($"Cat Height: {myCat.GetHeight()}");
        Console.WriteLine($"Cat Colour: {myCat.GetColour()}");
        Console.WriteLine($"Cat Age: {myCat.GetAge()}");
        myCat.Eat();
        Console.WriteLine($"Cat says: {myCat.Cry()}");

       
        List<IAnimal> animals = new List<IAnimal>();
        animals.Add(new Dog { Name = "Sheru", Height = 10, Colour = "Brown", Age = 2 });
        animals.Add(new Cat { Name = "masi", Height = 11, Colour = "Black", Age = 5 });

      
        Console.WriteLine("\nNames of all animals in the list:");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.GetName());
        }
        Console.ReadLine();
    }
}
