using API.Domain.Entities;

namespace API.Domain.Aggregates;

public class OrderAggregate
{
    public int Id { get; private set; }
    public DateTime OrderDate { get; private set; }
    public IList<OrderItemEntity> OrderItems { get; private set; }
    public CustomerEntity Customer { get; private set; }

    private void IsValid()
    {
        if (OrderItems == null || OrderItems.Count() == 0)
        {
            throw new InvalidOperationException("Order must have at least one item");
        }
        if (Customer == null || Customer.Id == 0)
        {
            throw new InvalidOperationException("Order must have a customer");
        }
    }
    public OrderAggregate(int id, CustomerEntity customer, DateTime orderDate, IList<OrderItemEntity> orderItems)
    {
        Id = id;
        Customer = customer;
        OrderDate = orderDate;
        OrderItems = orderItems;
        IsValid();
    }

    public OrderAggregate(CustomerEntity customer, DateTime orderDate, IList<OrderItemEntity> orderItems)
    {
        Customer = customer;
        OrderDate = orderDate;
        OrderItems = orderItems;
        IsValid();
    }
}