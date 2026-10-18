using System;

namespace PaintManagementSystem.Interfaces;
// 可购买商品接口（IBuyable 接⼝）
// 创建一个 接⼝ IBuyable，定义以下⽅法：
// decimal GetFinalPrice(); - 计算最终折后
// 价格的方法
// 所有可购买的产品都应该实现这个接口
public interface IBuyable
{
    decimal GetFinalPrice();
}
