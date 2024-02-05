using System;


public abstract class Animal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }
    public string GetName() => Name;
    public string GetColour() => Colour;
    public int GetAge() => Age;
    public void SetName(string name) => Name = name;
    public void SetColour(string colour) => Colour = colour;
    public void SetAge(int age) => Age = age;
    public abstract void Eat();
}
public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }
}
public class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        Console.Write("Enter dog name: ");
        myDog.SetName(Console.ReadLine());
        Console.Write("Enter dog colour: ");
        myDog.SetColour(Console.ReadLine());
        Console.Write("Enter dog age: ");
        myDog.SetAge(int.Parse(Console.ReadLine()));
        Console.WriteLine($"Dog Name: {myDog.GetName()}");
        Console.WriteLine($"Dog Colour: {myDog.GetColour()}");
        Console.WriteLine($"Dog Age: {myDog.GetAge()}");
        myDog.Eat();
        Cat myCat = new Cat();

        Console.Write("Enter cat name: ");
        myCat.SetName(Console.ReadLine());
        Console.Write("Enter cat colour: ");
        myCat.SetColour(Console.ReadLine());
        Console.Write("Enter cat age: ");
        myCat.SetAge(int.Parse(Console.ReadLine()));

        Console.WriteLine($"Cat Name: {myCat.GetName()}");
        Console.WriteLine($"Cat Colour: {myCat.GetColour()}");
        Console.WriteLine($"Cat Age: {myCat.GetAge()}");
        myCat.Eat();
        Console.ReadLine();
    }
}
