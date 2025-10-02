using System.Runtime.InteropServices;

public class Product
{
    private string _productName;
    private int _productID;
    private float _productPrice;
    private int _productQuantity;

    public Product(string productName, int productID, float productPrice, int productQuantity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public int BaseCost()
    {
        return (int)(_productPrice * _productQuantity);
    }
    public string PackingLabel()
    {
        return _productName + ", " + _productID + " ";
        
    }
}