using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictorianFurnitureFactory : FurnitureFactory
{
    Dictionary<string, Sofa> _sofaDictionary = new Dictionary<string, Sofa>();
    Dictionary<string, CoffeeTable> _coffeeTableDictionary = new Dictionary<string, CoffeeTable>();
    Dictionary<string, Chair> _chairDictionary = new Dictionary<string, Chair>();

    private const string _factoryID = "02";
    public override Furniture CreateProduct(FutnitureType product)
    {
        string productID = GenerateProductID(product);
        Furniture furniture = default;
        switch (product)
        {
            case FutnitureType.Sofa:
                Sofa sofa = new Sofa("Victorian Sofa", productID);
                _sofaDictionary.Add(sofa.ID, sofa);
                break;
            case FutnitureType.CoffeeTable:
                CoffeeTable coffeetable = new CoffeeTable("Victorian Coffee Table", productID);
                _coffeeTableDictionary.Add(coffeetable.ID, coffeetable);
                break;
            case FutnitureType.Chair:
                Chair chair = new Chair("Victorian Sofa", productID);
                _chairDictionary.Add(chair.ID, chair);
                break;
            default:
                throw new System.Exception("Product type not found");
        }
        Debug.LogFormat("{0} created. Here's ID {1}", furniture.Name, furniture.ID);
        return furniture;
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
