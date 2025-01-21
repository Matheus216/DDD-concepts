namespace API.Domain.Entities;

public record OrderEntity(int Id, int CustomerId, DateTime OrderDate, List<OrderItemEntity> OrderItems);