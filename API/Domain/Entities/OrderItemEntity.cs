namespace API.Domain.Entities;

public class OrderItemEntity(int Id, int Quantity, ProductEntity Product)
{
    public decimal GetTotal()
    {
        return Quantity * Product.Price;
    }

    public void IncreaseQuantity(int quantity) => Quantity += quantity;
    public void DrecreasesQuantity(int quantity)
    {
        if (Quantity - quantity < 0)
        {
            throw new InvalidOperationException("Quantity can't be less than 0");
        }
        Quantity -= quantity;
    }

}