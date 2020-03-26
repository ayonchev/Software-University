using System;
using System.Collections.Generic;
using System.Text;

public class Threeuple<T, U, K>
{
    public Threeuple(T firstItem, U secondItem, K thirdItem)
    {
        this.FirstItem = firstItem;
        this.SecondItem = secondItem;
        this.ThirdItem = thirdItem;
    }

    public T FirstItem { get; set; }
    public U SecondItem { get; set; }
    public K ThirdItem { get; set; }
    public override string ToString()
    {
        return $"{this.FirstItem} -> {this.SecondItem} -> {this.ThirdItem}";
    }
}
