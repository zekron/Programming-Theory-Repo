using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModernCoffeeTable : CoffeeTable
{
    public ModernCoffeeTable(string name, string id) : base(name, id)
    {
        //_name = name;
        //_ID = id;
    }

    public override string GetDescription()
    {
        return string.Format("{0} with modern design.", base.GetDescription());
    }
    public override double GetPrice()
    {
        return _price * 2;
    }
    public override void Sit()
    {
        Debug.Log("It looks modern. It's better than normal one.");
    }
}
