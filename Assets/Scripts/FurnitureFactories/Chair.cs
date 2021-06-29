using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : IFurniture
{
    protected string _name = "Basic Chair";
    protected string _ID = "XXXX";
    protected double _price = 10;
    public Chair(string name, string id)
    {
        _name = name;
        _ID = id;
    }

    public double GetPrice()
    {
        return _price;
    }

    public string GetDescription()
    {
        return string.Format("This is {0}.", _name);
    }

    public virtual void Sit()
    {
        Debug.Log("Just so so.");
    }
}
