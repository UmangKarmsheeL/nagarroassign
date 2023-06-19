using System;
using System.Collections.Generic;

class Product : IEquatable<Product>//Here we are creating Product class
{
    public int Id { get; set; }
    public double Price { get; set; }

    public bool Equals(Product other)
    {
        if (other == null) return false;
        return (this.Id.Equals(other.Id));
    }
}

class Inventory //Here we are creating Inventory class
{
    private Dictionary<Product, int> products = new();
    private double totalValue = 0;

    public void AddProduct(Product product, int quantity)//Add product method
    {
        if (products.ContainsKey(product))
        {
            products[product] += quantity;
        }
        else
        {
            products.Add(product, quantity);
        }

        totalValue += product.Price * quantity;
    }

    public void RemoveProduct(Product product, int quantity)//Remove product method
    {
        if (products.ContainsKey(product))
        {
            if (products[product] <= quantity)
            {
                totalValue -= product.Price * products[product];
                products.Remove(product);
            }
            else
            {
                totalValue -= product.Price * quantity;
                products[product] -= quantity;
            }
        }
    }

    public void UpdateProductQuantity(Product product, int newQuantity)//Update product method
    {
        if (products.ContainsKey(product))
        {
            int oldQuantity = products[product];
            products[product] = newQuantity;
            totalValue += product.Price * (newQuantity - oldQuantity);
        }
    }

    public void OnPriceChanged(object sender, EventArgs e)
    {
        Product product = (Product)sender;
        int quantity = products[product];
        totalValue -= product.Price * quantity;
        totalValue += product.Price * quantity;
    }

    public void OnProductDefective(object sender, EventArgs e)//On Product defective we Subtract its price 
    {                                                         //And also remove it from Product
        Product product = (Product)sender;
        int quantity = products[product];
        totalValue -= product.Price * quantity;
        products.Remove(product);
    }
}
    