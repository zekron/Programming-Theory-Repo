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

    public override string GetDescription()
    {
        return string.Format("{0} with modern design. It's so comfortable that anyone lays on it will fall asleep soon.", base.GetDescription());
    }
    public override double GetPrice()
    {
        return _price * 3;
    }
    public override void Sit()
    {
        Debug.Log("It looks modern. It's better than normal one.");
    }
}
