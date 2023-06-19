using System;

namespace DuckSimulation 
{
    enum DuckType //Here we are creating different type of duck using enum.
    {
        RubberDuck,
        MallardDuck,
        RedheadDuck
    }

    interface IDuck //Here we are creating interface to assign common behavior among different classes.
    {
        void Fly();
        void Quack();
    }

    class Duck : IDuck 
    {
        public int Weight { get; set; }
        public int NumberOfWings { get; set; }
        public DuckType Type { get; set; }

        public Duck(int weight, int numberOfWings, DuckType type) 
        {
            Weight = weight;
            NumberOfWings = numberOfWings;
            Type = type;
        }

        public void Fly() //Here we are modifying methods according to ducktype.
        {
            switch (Type) 
            {
                case DuckType.MallardDuck:
                    Console.WriteLine("Flying fast");
                    break;
                case DuckType.RedheadDuck:
                    Console.WriteLine("Flying slow");
                    break;
                case DuckType.RubberDuck:
                    Console.WriteLine("Can't fly");
                    break;
            }
        }

        public void Quack() 
        {
            switch (Type) 
            {
                case DuckType.MallardDuck:
                    Console.WriteLine("Quacking loud");
                    break;
                case DuckType.RedheadDuck:
                    Console.WriteLine("Quacking mild");
                    break;
                case DuckType.RubberDuck:
                    Console.WriteLine("Squeaking");
                    break;
            }
        }

        public void ShowDetails() 
        {
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Number of Wings: " + NumberOfWings);
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            Duck rubberDuck = new Duck(5, 0, DuckType.RubberDuck);
            rubberDuck.Fly(); // output: Can't fly
            rubberDuck.Quack(); // output: Squeaking
            rubberDuck.ShowDetails(); 
            // output: 
            // Type: RubberDuck
            // Weight: 5
            // Number of Wings: 0

            Duck mallardDuck = new Duck(10, 2, DuckType.MallardDuck);
            mallardDuck.Fly(); // output: Flying fast
            mallardDuck.Quack(); // output: Quacking loud
            mallardDuck.ShowDetails();
            // output: 
            // Type: MallardDuck
            // Weight: 10
            // Number of Wings: 2

            Duck RedheadDuck = new Duck(12, 2 , DuckType.RedheadDuck);
            RedheadDuck.Fly(); // output: Flyinging fast
            RedheadDuck.Quack(); // output: Quacking slow
            RedheadDuck.ShowDetails();
            // output: 
            // Type: RedheadDuck
            // Weight: 12
            // Number of Wings: 2
        }
    }
}