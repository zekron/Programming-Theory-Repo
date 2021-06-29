using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFurniture
{
    public double GetPrice();
    public string GetDescription();
}

public enum FutnitureType
{
    Sofa,
    CoffeeTable,
    Chair,
}
