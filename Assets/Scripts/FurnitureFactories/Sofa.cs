using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sofa : IFurniture
{
    protected string _name = "Basic Sofa";
    protected string _ID = "XXXX";
    protected double _price = 25;

    public string ID { get => _ID; }
    public string Name { get => _name; }
    public Sofa(string name, string id)
    {
        _name = name;
        _ID = id;
    }

    public virtual double GetPrice()
    {
        return _price;
    }

    public virtual string GetDescription()
    {
        return string.Format("This is {0}.", _name);
    }

    public virtual void Sit()
    {
        Debug.Log("Just so so.");
    }
}
