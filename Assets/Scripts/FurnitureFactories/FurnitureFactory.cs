using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FurnitureFactory : MonoBehaviour
{
    private const string _chairID = "0101";
    private const string _coffeeTableID = "0102";
    private const string _sofaID = "0103";

    protected string ChairID { get => _chairID; }
    protected string CoffeeTableID { get => _coffeeTableID; }
    protected string SofaID { get => _sofaID; }

    public abstract Furniture CreateProduct(FutnitureType product);
    public abstract string GenerateProductID(FutnitureType product);
}
