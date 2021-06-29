using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictorianCoffeeTable : CoffeeTable
{
    public VictorianCoffeeTable(string name, string id) : base(name, id)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription();
    }

    public override double GetPrice()
    {
        return base.GetPrice() * 3.5;
    }

    public override void Sit()
    {
        base.Sit();
    }
}
