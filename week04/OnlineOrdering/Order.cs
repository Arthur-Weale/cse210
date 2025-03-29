


public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer ;

    public Order(Customer customer)
    {
        _customer = customer;
    }


    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetShippingCost()
{
    if (_customer.IsInUSA()) // Assuming _customer is the Customer object associated with this order
    {
        return 5.0; // Shipping cost for USA
    }
    else
    {
        return 35.0; // Shipping cost for non-USA
    }
}

    public double CalculateTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        totalCost += GetShippingCost(); // Add shipping cost based on the customer's address
    
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
    foreach (Product product in _products)
    {
        packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
    }
    return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n {_customer.GetAddress().GetFullAddress()}";
    }
}