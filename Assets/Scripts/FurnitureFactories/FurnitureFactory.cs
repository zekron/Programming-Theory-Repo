using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FurnitureFactory : MonoBehaviour
{
    private string _name;
    private int _ID;

    public string Name { get => _name; set => _name = value; }
    public int Int { get => _ID; set => _ID = value; }

    public abstract void CreateProduct(Product product);
}

public enum Product
{
    Sofa,
    CoffeeTable,
    Chair,
}
