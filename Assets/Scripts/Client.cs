using UnityEngine;

public class Client : MonoBehaviour
{
    FurnitureFactory _victorianFactory = new VictorianFurnitureFactory();
    FurnitureFactory _modernFactory = new ModernFurnitureFactory();
    FurnitureFactory _clientFactory;

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
