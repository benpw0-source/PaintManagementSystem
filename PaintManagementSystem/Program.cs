using PaintManagementSystem.Enums;
using PaintManagementSystem.Models;

//创建多个 PaintProduct 油漆产品
var whiteSpecification = new PaintSpecification("White", 10);
var blackSpecification = new PaintSpecification("Black", 20);
var purpleSpecification = new PaintSpecification("Purple", 30);

var band1 = new Brand("grand");

var product1 = new PaintProduct("White wall paint", PaintType.Matte, whiteSpecification, 25m, band1);
var product2 = new PaintProduct("Black wall paint", PaintType.Glossy, blackSpecification, 50m,band1);
var product3 = new PaintProduct("Purple wall paint", PaintType.Matte, purpleSpecification, 50m,band1);

decimal finalPrice = 0m;
// 显示所有可⽤产品
var products = new []{product1,product2,product3};

foreach(var product in products)
{
     Console.WriteLine( $"{product.Name} | Type: {product.Type} | Color: {product.Specification.Color} | " +
        $"Size: {product.Specification.SizeInLiters} L | Price: {product.GetFinalPrice():C}");
}

// 创建一个订单
// var order = new Order(product1, 2);
// 增加 Order 允许多个商品（用Array）, 并新增GetTotalOrderPrice 方法， 循环多个Product 计算总价格
Order[] orders = new Order[]
{
    new Order(product1, 2),
    new Order(product2, 2)
};


// 显示订单详情
// order.DisplayOrder();
//新增GetTotalOrderPrice 方法， 循环多个Product 计算总价格
void  GetTotalOrderPrice( Order[] orders)
{
    
    foreach( var order in orders)
    {
        finalPrice += order.TotalPrice;
    }
}

GetTotalOrderPrice(orders);

