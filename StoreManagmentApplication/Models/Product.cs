namespace StoreManagmentApplication.Models;

class Product : Entity
{
    private static int _autoIncrementId = 1;

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
        Id = _autoIncrementId++;
    }

    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"{Name} {Price}";
    }
}
