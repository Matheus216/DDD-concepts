using API.Services.Order;

namespace Test.Services.Order;

public class OrderServiceTest
{
    [Fact]
    public void CreateOrder_ShouldThrowNotImplementedException()
    {
        // Arrange
        var orderService = new OrderService();

        // Act & Assert
        Assert.Throws<NotImplementedException>(() => orderService.CreateOrder());
    }
}