using System;
using System.Net.Http.Headers;

namespace PaintManagementSystem.Models;

public class Order
{
    public readonly DateTime CreatedAt = DateTime.Now;

    public PaintProduct Product{ get; set; }
    public int Quantity{ get; set; }
    public decimal TotalPrice{ get; set; }

    //多个products
    public PaintProduct[] Products{ get; set; }
    public Order(PaintProduct paintProduct, int quantity)
    {
        Product = paintProduct;
        Quantity = quantity;
        TotalPrice = quantity*Product.GetFinalPrice();

    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Created: {CreatedAt:g}");
        Console.WriteLine($"Product: {Product.Name} ({Product.Type}, {Product.Specification.Color}, {Product.Specification.SizeInLiters} L)");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Unit price: {Product.GetFinalPrice():C}");
        Console.WriteLine($"Total: {GetTotalPrice():C}");
    }

    public decimal GetTotalPrice()
    {
        // if there are more than many products in array, then use for each and find the price and add up. 
        TotalPrice =  Quantity * Product.GetFinalPrice();
        return TotalPrice;
    }

}
