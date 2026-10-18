using System;
using PaintManagementSystem.Enums;
using PaintManagementSystem.Interfaces;

namespace PaintManagementSystem.Models;

public class PaintProduct:IBuyable
{
    //or define TaxRate in PaintProduct(){ TaxRate =0.1m;}
    public readonly decimal TaxRate;
    public const decimal DefaultDiscount = 0.05m;

    public string Name{ get; set; }
    public PaintType Type{ get; set; }
    public PaintSpecification Specification{ get; set; }
    decimal Price{ get; set; }
    public Brand Brand; 

    public PaintProduct(string name, PaintType type, PaintSpecification specification, decimal price,Brand brand)
    {
        Name = name;
        Price = price;
        Type = type;
        Specification = specification;
        TaxRate =0.1m;
        Brand = brand;

    }
// 构造函数
// 初始化 Name, Type, Specification, Price, TaxRate
    public decimal GetFinalPrice()
    {
        decimal FinalPrice = (1-DefaultDiscount) * Price *(1+TaxRate);
        Console.WriteLine("Current price is " + FinalPrice);
        return FinalPrice;
    }

    public PaintSpecification DisplayInfo()
    {
        Console.WriteLine(Specification.Color+ Specification.SizeInLiters);
        return Specification;
    }

    public decimal GetMaxDiscount(int rate, bool isOverridable)
    {
        decimal RateCal = rate*0.01m;
        if (isOverridable == true)
        {
            return RateCal;
        }
        else
        {
            return DefaultDiscount;
        }
       
    }
}
