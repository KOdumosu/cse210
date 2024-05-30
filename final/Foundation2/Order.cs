public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalCost();
        }

        if (_customer.IsInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice +=35;
        }
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Customer Name: {_customer.GetName()}, Address: {_customer.GetAddressString()}";
    }
}