using System;
using System.Data;
using System.Security.Cryptography;

namespace PaintManagementSystem.Models;

//油漆规格（PaintSpecification 类）
// 定义一个 class - PaintSpecification，⽤于存储油漆规格信息：
// Color（颜色，字符串类型）
// SizeInLiters（容量，整数，单位：升）
// 提供
// 一个 构造函数 初始化 Color 和 SizeInLiters
// 提供
// 一个 DisplaySpecification() ⽅法 ⽤于输出规格信息

public class PaintSpecification
{
    public string Color{get;set;}
    public int SizeInLiters{get;set;}
    
    //  一个 构造函数 初始化 Color 和 SizeInLiters
     public PaintSpecification(string color, int sizeInLiters)
    {
        Color = color;
        SizeInLiters = sizeInLiters;
    }

// 一个 DisplaySpecification() ⽅法 ⽤于输出规格信息
    public PaintSpecification DisplaySpecification(PaintSpecification paintSpecification)
    {
        return paintSpecification;
    }
}
