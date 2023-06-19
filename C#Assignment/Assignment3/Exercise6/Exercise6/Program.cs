using System;
using System.Collections.Generic;
using System.Linq;

class Equipment
{
    // Here we are creating equipment detail
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsMobile { get; set; }
    public double DistanceMoved { get; set; }
    public double MaintenanceCost { get; set; }
}

class Program
{
    static List<Equipment> equipments = new List<Equipment>();// Here we are creating list.

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("1. Create an equipment");
            Console.WriteLine("2. Delete an equipment");
            Console.WriteLine("3. Move an equipment");
            Console.WriteLine("4. List all equipment");
            Console.WriteLine("5. Show details of an equipment");
            Console.WriteLine("6. List all mobile equipment");
            Console.WriteLine("7. List all immobile equipment");
            Console.WriteLine("8. List all equipment that have not been moved till now");
            Console.WriteLine("9. Delete all equipment");
            Console.WriteLine("10. Delete all immobile equipment");
            Console.WriteLine("11. Delete all mobile equipment");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)  //switch case functionality according to input 
            {
                case 1:
                    CreateEquipment();
                    break;
                case 2:
                    DeleteEquipment();
                    break;
                case 3:
                    MoveEquipment();
                    break;
                case 4:
                    ListAllEquipment();
                    break;
                case 5:
                    ShowEquipmentDetails();
                    break;
                case 6:
                    ListAllMobileEquipment();
                    break;
                case 7:
                    ListAllImmobileEquipment();
                    break;
                case 8:
                    ListAllEquipmentNotMoved();
                    break;
                case 9:
                    DeleteAllEquipment();
                    break;
                case 10:
                    DeleteAllImmobileEquipment();
                    break;
                case 11:
                    DeleteAllMobileEquipment();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

    static void CreateEquipment() //creating equipment
    {
        Console.WriteLine("Enter equipment name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter equipment description: ");
        string description = Console.ReadLine();

        Console.WriteLine("Is the equipment mobile? (y/n)");
        bool isMobile = Console.ReadLine().ToLower() == "y";

        Equipment equipment = new Equipment
        {
            Name = name,
            Description = description,
            IsMobile = isMobile
        };

        equipments.Add(equipment);

        Console.WriteLine("Equipment created successfully");
    }

    static void DeleteEquipment()
    {
        Console.WriteLine("Enter equipment name: ");
        string name = Console.ReadLine();

        Equipment equipment = equipments.FirstOrDefault(e => e.Name == name);// Here we are using lambda expression, FirstOrDefault is LINQ method.

        if (equipment == null)
        {
            Console.WriteLine("Equipment not found");
        }
        else
        {
            equipments.Remove(equipment);
            Console.WriteLine("Equipment deleted successfully");
        }
    }

    static void MoveEquipment()
    {
        Console.WriteLine("Enter equipment name: ");
        string name = Console.ReadLine();

        Equipment equipment = equipments.FirstOrDefault(e => e.Name == name);

        if (equipment == null)
        {
            Console.WriteLine("Equipment not found");
        }
        else
        {
            Console.WriteLine("Enter distance moved: ");
            double distance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter maintenance cost: ");
            double cost = double.Parse(Console.ReadLine());

            equipment.DistanceMoved += distance;
            equipment.MaintenanceCost += cost;

            Console.WriteLine("Equipment moved successfully");
        }
    }
    static void ListAllEquipment()
    {
        Console.WriteLine("List of all equipment: ");
        foreach (Equipment equipment in equipments)
        {
            Console.WriteLine($"Name: {equipment.Name}, Description: {equipment.Description}");
        }
    }

    static void ShowEquipmentDetails()
    {
        Console.WriteLine("Enter equipment name: ");
        string name = Console.ReadLine();

        Equipment equipment = equipments.FirstOrDefault(e => e.Name == name);

        if (equipment == null)
        {
            Console.WriteLine("Equipment not found");
        }
        else
        {
            Console.WriteLine($"Name: {equipment.Name}");
            Console.WriteLine($"Description: {equipment.Description}");
            Console.WriteLine($"Distance moved: {equipment.DistanceMoved}");
            Console.WriteLine($"Maintenance cost: {equipment.MaintenanceCost}");
        }
    }

    static void ListAllMobileEquipment()
    {
        var mobileEquipment = equipments.Where(e => e.IsMobile);//Here we are using Where query.

        Console.WriteLine("List of all mobile equipment: ");
        foreach (Equipment equipment in mobileEquipment)
        {
            Console.WriteLine($"Name: {equipment.Name}, Description: {equipment.Description}");
        }
    }

    static void ListAllImmobileEquipment()
    {
        var immobileEquipment = equipments.Where(e => !e.IsMobile);

        Console.WriteLine("List of all immobile equipment: ");
        foreach (Equipment equipment in immobileEquipment)
        {
            Console.WriteLine($"Name: {equipment.Name}, Description: {equipment.Description}");
        }
    }

    static void ListAllEquipmentNotMoved()
    {
        var notMovedEquipment = equipments.Where(e => e.DistanceMoved == 0);

        Console.WriteLine("List of all equipment that have not been moved till now: ");
        foreach (Equipment equipment in notMovedEquipment)
        {
            Console.WriteLine($"Name: {equipment.Name}, Description: {equipment.Description}");
        }
    }

    static void DeleteAllEquipment()
    {
        equipments.Clear();

        Console.WriteLine("All equipment deleted successfully");
    }

    static void DeleteAllImmobileEquipment()
    {
        equipments.RemoveAll(e => !e.IsMobile);

        Console.WriteLine("All immobile equipment deleted successfully");
    }

    static void DeleteAllMobileEquipment()
    {
        equipments.RemoveAll(e => e.IsMobile);

        Console.WriteLine("All mobile equipment deleted successfully");
    }
}