using System;
using System.Collections.Generic;
using System.Text;

public class Citizen : IBuyer
{
    public Citizen()
    {
        this.FoodAmount = 0;
    }
    public int FoodAmount { get; set; }

    public void BuyFood()
    {
        FoodAmount += 10;
    }
}

