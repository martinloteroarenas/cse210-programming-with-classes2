public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public int OrderTotalCost()
    {
        int totalCost = 0;
        foreach(Product product in _products)
        {
            totalCost = totalCost + product.ProductTotalCost();
        }
        if (_customer.AddressValidator() == true)
        {
            totalCost = totalCost + 5;
            return totalCost;
        }
        else
        {
            totalCost = totalCost + 35;
            return totalCost;
        }
    }

    public string GetDisplayPackingLabel()
    {
        string label = "";
        foreach(Product product in _products)
        {
            label = label + product.GetDisplayLabel();
        }
        return label;
    }

    public string GetDisplayShippingLabel()
    {
        return _customer.GetDisplayShippingLabel();
    }

    public void AddProducts(Product product)
    {
        _products.Add(product);
    }

}