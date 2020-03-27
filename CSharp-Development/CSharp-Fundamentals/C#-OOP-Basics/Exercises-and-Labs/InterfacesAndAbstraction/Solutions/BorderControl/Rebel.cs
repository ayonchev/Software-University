using System;
using System.Collections.Generic;
using System.Text;

public class Rebel : IBuyer
{
    public Rebel()
    {
        this.FoodAmount = 0;
    }
    public int FoodAmount { get; set; }

    public void BuyFood()
    {
        FoodAmount += 5;
    }
}

