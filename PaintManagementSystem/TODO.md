油漆类型（PaintType 枚举）
定义一个 enum PaintType 来表⽰不同类型的油漆：
BaseCoat - 底漆
Glossy - 高光漆
Matte - 哑光漆



油漆规格（PaintSpecification 类）
定义一个 class - PaintSpecification，⽤于存储油漆规格信息：
Color（颜色，字符串类型）
SizeInLiters（容量，整数，单位：升）
提供
一个 构造函数 初始化 Color 和 SizeInLiters
提供
一个 DisplaySpecification() ⽅法 ⽤于输出规格信息


可购买商品接口（IBuyable 接⼝）
创建一个 接⼝ IBuyable，定义以下⽅法：
decimal GetFinalPrice(); - 计算最终折后
价格的方法
所有可购买的产品都应该实现这个接口




油漆产品（PaintProduct 类）
创建一个 PaintProduct 类，表⽰⼀个油漆产品：
只读字段（readonly）
TaxRate（税率，在运行时初始化10%）
常量（const）
DefaultDiscount（统
一
折扣，5%）
自动属性
Name（油漆名称，字符串）
Type（油漆类型，枚举 PaintType）
Specification（油漆规格，PaintSpecification ）
Price（原价，decimal）
构造函数
初始化 Name, Type, Specification, Price, TaxRate
方法
GetFinalPrice()：计算折扣后含税价格， 该方法是由实现了IBuyable 接⼝
DisplayInfo()：输出油漆产品的详细信息
GetMaxDiscount: 计算折扣， 传入int rate 和isOverridable



订单类（Order 类）(！类可以作为
另一个类的成员)
创建一个 Order 类，表⽰⼀个订单：
只读属性（readonly）
CreatedAt（订单创建时间）(需要思考在哪里初始化)
属性
Product（油漆产品，类型 PaintProduct）
Quantity（购买数量，整数）
TotalPrice（总价，decimal）
构造函数
接收 paintProduct 和 quantity 作为参数，并初始化 TotalPrice
方法
DisplayOrder()：输出订单的详细信息
GetTotalPrice(): 输出所有油漆价格



主程序（Program 类）
在 Main() 方法中：
创建多个 PaintProduct 油漆产品
显示所有可⽤产品
创建一个订单
显示订单详情



增加更多油漆种类Type（SemiGloss, Gloss, WhiteOnWhite ）。
增加 Brand（品牌）类， 在PaintProduct中加入Brand 类作为成员
增加 Order 允许多个商品（用Array）, 并新增GetTotalOrderPrice 方法， 循环多个Product 计算总价格
增加 PaintStore 类来存储可购买的油漆产品, 用Array来保存多个油漆产品