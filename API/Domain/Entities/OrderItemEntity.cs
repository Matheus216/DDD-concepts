namespace API.Domain.Entities;

public record OrderItemEntity(int Id, int OrderId, int ProductId, int Quantity);