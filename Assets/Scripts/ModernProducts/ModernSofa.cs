using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModernSofa : Sofa
{
    public ModernSofa(string name, string id) : base(name, id)
    {
        //_name = name;
        //_ID = id;
    }

    public override double GetPrice()
    {
        return _price;
    }
    public override void Sit()
    {
        Debug.Log("It looks modern. It's better than normal one.");
    }
}
