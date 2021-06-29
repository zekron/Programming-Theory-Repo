using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    FurnitureFactory _victorianFactory = new VictorianFurnitureFactory();
    FurnitureFactory _modernFactory = new ModernFurnitureFactory();
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Sofa sofa = _victorianFactory.CreateProduct<Sofa>(FutnitureType.Sofa);
            sofa.Sit();
            Debug.Log($"The price is {sofa.GetPrice():C}");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Chair chair = _victorianFactory.CreateProduct<Chair>(FutnitureType.Chair);
            chair.Sit();
            Debug.Log($"The price is {chair.GetPrice():C}");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CoffeeTable coffeeTable = _victorianFactory.CreateProduct<CoffeeTable>(FutnitureType.CoffeeTable);
            coffeeTable.HaveALook();
            Debug.Log($"The price is {coffeeTable.GetPrice():C}");
        }
    }
}
