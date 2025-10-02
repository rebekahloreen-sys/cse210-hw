public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private float _shippingCost;

    public Order(Customer customer, float shippingCost)
    {
        _shippingCost = shippingCost;
        _customer = customer;
    }

    public float CalculateTotal()
    {
        int _shippingCost = _customer.InUSA() ? 5 : 35;
        float totalProducts = 0;
        foreach (var product in _products)
        {
            totalProducts += product.BaseCost();
        }
        return totalProducts + _shippingCost;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string PackingLabel()
    {
        string label = "";
        foreach (Product p in _products)
        {
            label += p.PackingLabel() + "\n";
        }
        return label;
    }
    public string ShippingLabel()
    {
        return _customer.ShippingLabel();//
    }
 
}