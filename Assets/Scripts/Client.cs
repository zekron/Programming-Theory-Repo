using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FurnitureFactory factory = new ModernFurnitureFactory();
        Furniture furniture = factory.CreateProduct(FutnitureType.Sofa);
    }
}
