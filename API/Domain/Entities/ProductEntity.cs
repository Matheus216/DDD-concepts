namespace API.Domain.Entities;

public class ProductEntity
{
    public int Id { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }

    public ProductEntity(string description, decimal price)
    {
        Description = description;
        Price = price;
        IsValid();
    }

    public ProductEntity(int id, string description, decimal price)
    {
        Id = id;
        Description = description;
        Price = price;
        IsValid();
    }

    private void IsValid()
    {
        if (string.IsNullOrEmpty(Description))
        {
            throw new InvalidOperationException("Description can't be empty");
        }
        if (Price < 0)
        {
            throw new InvalidOperationException("Price can't be less than 0");
        }
    }

    public void UpdatePrice(decimal price)
    {
        if (price < 0)
        {
            throw new InvalidOperationException("Price can't be less than 0");
        }
        Price = price;
    }
    public void UpdateDescription(string description)
    {
        if (string.IsNullOrEmpty(description))
        {
            throw new InvalidOperationException("Description can't be empty");
        }
        Description = description;
    }
}