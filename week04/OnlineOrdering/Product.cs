



public class Product
{
    private string _name;
    private int _productId;
    private float _price;
    private int _quantity;

    public Product(string name , int prodductId, float price, int quantity)
    {
        _name = name;
        _productId = prodductId;
        _price = price;
        _quantity = quantity;
    }

    
    public string GetName()
    {
        return _name; 
    }

    public int GetProductId()
    {
        return _productId; 
    }

    public float GetTotalCost()
    {
        return _price * _quantity;
    }
}