using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModernFurnitureFactory : FurnitureFactory
{
    Dictionary<string, Sofa> _sofaDictionary = new Dictionary<string, Sofa>();
    Dictionary<string, CoffeeTable> _coffeeTableDictionary = new Dictionary<string, CoffeeTable>();
    Dictionary<string, Chair> _chairDictionary = new Dictionary<string, Chair>();

    private const string _factoryID = "01";
    public override T CreateProduct<T>(FutnitureType product)
    {
        string productID = GenerateProductID(product);
        IFurniture furniture = default;
        switch (product)
        {
            case FutnitureType.Sofa:
                furniture = new Sofa("Modern Sofa", productID);
                _sofaDictionary.Add(productID, furniture as Sofa);
                break;
            case FutnitureType.CoffeeTable:
                furniture = new CoffeeTable("Modern Coffee Table", productID);
                _coffeeTableDictionary.Add(productID, furniture as CoffeeTable);
                break;
            case FutnitureType.Chair:
                furniture = new Chair("Modern Sofa", productID);
                _chairDictionary.Add(productID, furniture as Chair);
                break;
            default:
                throw new System.Exception("Product type not found");
        }
        Debug.LogFormat("{0} Here's ID {1}", furniture.GetDescription(), productID);
        return (T)furniture;
    }

    public override string GenerateProductID(FutnitureType product)
    {
        switch (product)
        {
            case FutnitureType.Sofa:
                return string.Format("F{1}P{0}{2:X}", SofaID, _factoryID, _sofaDictionary.Count);
            case FutnitureType.CoffeeTable:
                return string.Format("F{1}P{0}{2:X}", CoffeeTableID, _factoryID, _coffeeTableDictionary.Count);
            case FutnitureType.Chair:
                return string.Format("F{1}P{0}{2:X}", ChairID, _factoryID, _chairDictionary.Count);
            default:
                throw new System.Exception("Product type not found");
        }
    }
}
