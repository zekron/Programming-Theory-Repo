using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FurnitureFactory factory = new VictorianFurnitureFactory();
        Sofa sofa = factory.CreateProduct<Sofa>(FutnitureType.Sofa);
        sofa.Sit();
        Debug.Log($"The price is {sofa.GetPrice():C}");
    }
}
