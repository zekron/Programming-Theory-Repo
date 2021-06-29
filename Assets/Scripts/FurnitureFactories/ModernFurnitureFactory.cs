using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModernFactory : FurnitureFactory
{
    public override void CreateProduct(Product product)
    {
        switch (product)
        {
            case Product.Sofa:
                break;
            case Product.CoffeeTable:
                break;
            case Product.Chair:
                break;
            default:
                Debug.Log("Product not found.");
                break;
        }
    }
}
