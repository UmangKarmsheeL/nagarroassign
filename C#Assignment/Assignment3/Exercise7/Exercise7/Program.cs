using System;
using System.Collections.Generic;
using System.Linq;

public class Duck
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public int NumberOfWings { get; set; }

    public Duck(string name, double weight, int numberOfWings)
    {
        Name = name;
        Weight = weight;
        NumberOfWings = numberOfWings;
    }
}

public class DuckCollection
{
    private List<Duck> ducks;

    public DuckCollection()
    {
        ducks = new List<Duck>();
    }

    public void AddDuck(Duck duck)
    {
        ducks.Add(duck);
    }

    public void RemoveDuck(Duck duck)
    {
        ducks.Remove(duck);
    }

    public void RemoveAllDucks()
    {
        ducks.Clear();
    }

    public IEnumerable<Duck> SortByWeight()
    {
        return ducks.OrderBy(duck => duck.Weight);
    }

    public IEnumerable<Duck> SortByNumberOfWings()
    {
        return ducks.OrderBy(duck => duck.NumberOfWings);
    }
}

// Example use
public class Program
{
    public static void Main()
    {
        DuckCollection duckCollection = new DuckCollection();

        duckCollection.AddDuck(new Duck("Daffy", 5.5, 2));
        duckCollection.AddDuck(new Duck("Donald", 6.2, 2));
        duckCollection.AddDuck(new Duck("Howard", 3.7, 2));
        duckCollection.AddDuck(new Duck("Puddles", 2.3, 1));

        Console.WriteLine("Ducks sorted by weight:");
        foreach (Duck duck in duckCollection.SortByWeight())
        {
            Console.WriteLine($"{duck.Name}: {duck.Weight} kg");
        }

        Console.WriteLine("Ducks sorted by number of wings:");
        foreach (Duck duck in duckCollection.SortByNumberOfWings())
        {
            Console.WriteLine($"{duck.Name}: {duck.NumberOfWings} wings");
        }
    }
}