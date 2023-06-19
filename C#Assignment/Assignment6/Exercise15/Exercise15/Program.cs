using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {
        ObservableCollection<string> collection = new();//we Create an instance of ObservableCollection<string>

        collection.CollectionChanged += OnCollectionChanged;

        collection.Add("X");// we add X elements to the collection


        collection.Remove("X");// we remove X element to the collection

        Console.ReadLine();//wait for input before closing console window
    }

    static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)// using NotifyCollectionChangedEventArgs enum to determine type of operation
        {
            case NotifyCollectionChangedAction.Add:
                Console.WriteLine($"Element '{e.NewItems[0]}' is added in collection");
                break;
            case NotifyCollectionChangedAction.Remove:
                Console.WriteLine($"Element '{e.OldItems[0]}' is removed from collection");
                break;
        }
    }
}