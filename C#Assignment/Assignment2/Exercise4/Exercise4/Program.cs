using System;

namespace Exercise4
{
    public enum EquipmentType
    {
        Mobile,
        Immobile
    }

    public abstract class Equipment
    {
        public string Name { get; }
        public string Description { get; }
        public int DistanceMoved { get; protected set; }
        public int MaintenanceCost { get; protected set; }
        public EquipmentType EquipmentType { get; }

        public Equipment(string name, string description, EquipmentType equipmentType)
        {
            Name = name;
            Description = description;
            DistanceMoved = 0;
            MaintenanceCost = 0;
            EquipmentType = equipmentType;
        }

        public abstract void MoveBy(int distance);

        protected virtual int CalculateMaintenanceCost(int distance)
        {
            return 0; // default implementation does not increase cost as initial cost is 0
        }
    }

    public class MobileEquipment : Equipment
    {
        public int NumberOfWheels { get; }

        public MobileEquipment(string name, string description, int numberOfWheels) : base(name, description, EquipmentType.Mobile)
        {
            NumberOfWheels = numberOfWheels;
        }
        public override void MoveBy(int distance)
        {
            DistanceMoved += distance;
            MaintenanceCost += (NumberOfWheels * distance) + CalculateMaintenanceCost(distance);
        }

    }

    class ImmobileEquipment : Equipment
    {
        public int Weight { get; }

        public ImmobileEquipment(string name, string description, int weight) : base(name, description, EquipmentType.Immobile)
        {
            Weight = weight;
        }

        public override void MoveBy(int distance)
        {
            DistanceMoved =+ distance;
            MaintenanceCost += (Weight * distance) + CalculateMaintenanceCost(distance);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a mobile Equipment");
            Console.Write("Enter the name: ");
            string mobileName = Console.ReadLine();
            Console.Write("Enter the description: ");
            string mobileDescription = Console.ReadLine();
            Console.Write("Enter the number of wheels: ");
            int mobileWheels = int.Parse(Console.ReadLine());
            MobileEquipment mobileEquipment = new(mobileName, mobileDescription, mobileWheels);

            Console.WriteLine("Creating a Immobile Equipment");
            Console.Write("Enter the name: ");
            string immobileName = Console.ReadLine();
            Console.Write("Enter the description: ");
            string immobileDescription = Console.ReadLine();
            Console.Write("Enter the Weight: ");
            int immobileWheels = int.Parse(Console.ReadLine());
            ImmobileEquipment immobileEquipment = new(immobileName, immobileDescription, immobileWheels);


            Console.WriteLine("\nMobile Equipment Details:");
            Console.WriteLine($"Name: {mobileEquipment.Name}");
            Console.WriteLine($"Description: {mobileEquipment.Description}");
            Console.WriteLine($"Number of Wheels: {mobileEquipment.NumberOfWheels}");
            Console.WriteLine($"Distance Moved: {mobileEquipment.DistanceMoved} km");
            Console.WriteLine($"Maintenance Cost: ${mobileEquipment.MaintenanceCost}");

            Console.WriteLine("\nImMobile Equipment Details:");
            Console.WriteLine($"Name: {immobileEquipment.Name}");
            Console.WriteLine($"Description: {immobileEquipment.Description}");
            Console.WriteLine($"Weight: {immobileEquipment.Weight} kg");
            Console.WriteLine($"Distance Moved: {immobileEquipment.DistanceMoved} km");
            Console.WriteLine($"Maintenance Cost: ${immobileEquipment.MaintenanceCost}");
        }
    }



}
