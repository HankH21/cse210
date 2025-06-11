public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        double totalCost = _price * _quantity;
        return totalCost;
    }

    public string GetProductInfo()
    {
        return $"{_productID} {_productName} {_quantity}";
    }
}