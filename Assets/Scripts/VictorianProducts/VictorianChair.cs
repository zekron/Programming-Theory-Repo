using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictorianChair : Chair
{
    public VictorianChair(string name, string id) : base(name, id)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription();
    }

    public override double GetPrice()
    {
        return base.GetPrice() * 4;
    }

    public override void Sit()
    {
        base.Sit();
    }
}
