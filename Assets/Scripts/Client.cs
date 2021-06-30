using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    FurnitureFactory _victorianFactory = new VictorianFurnitureFactory();
    FurnitureFactory _modernFactory = new ModernFurnitureFactory();
    FurnitureFactory _clientFactory;

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

    public void UseModernFactory()
    {
        _clientFactory = _modernFactory;
    }

    public void UseVictorianFactory()
    {
        _clientFactory = _victorianFactory;
    }

    public void CreateSofa()
    {
        if (_clientFactory == null) return;

        Sofa sofa = _clientFactory.CreateProduct<Sofa>(FutnitureType.Sofa);
        sofa.Sit();
        Debug.Log($"The price is {sofa.GetPrice():C}");
    }
    public void CreateCoffeeTable()
    {
        if (_clientFactory == null) return;

        CoffeeTable coffeeTable = _clientFactory.CreateProduct<CoffeeTable>(FutnitureType.CoffeeTable);
        coffeeTable.HaveALook();
        Debug.Log($"The price is {coffeeTable.GetPrice():C}");
    }
    public void CreateChair()
    {
        if (_clientFactory == null) return;

        Chair chair = _clientFactory.CreateProduct<Chair>(FutnitureType.Chair);
        chair.Sit();
        Debug.Log($"The price is {chair.GetPrice():C}");
    }
}
