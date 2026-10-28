using System;

namespace PaintManagementSystem.Models;

public class PaintStore
{
    public PaintProduct[] PaintProducts{get;set;}
    public PaintStore(PaintProduct[] paintProducts)
    {
        PaintProducts = paintProducts;
    }
}
