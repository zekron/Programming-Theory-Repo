using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour
{
    protected string _name = "Furniture";
    protected string _ID = "XXXX";

    public string ID { get => _ID; }
    public string Name { get => _name; }
}

public enum FutnitureType
{
    Sofa,
    CoffeeTable,
    Chair,
}
