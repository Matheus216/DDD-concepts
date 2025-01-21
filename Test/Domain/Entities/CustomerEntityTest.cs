using API.Domain.Entities;
using API.Domain.ObjectValues;
using Bogus;
using Bogus.Extensions.Brazil;
using Xunit;

namespace YourNamespace.Tests
{
    public class CustomerEntityTest
    {
        private readonly Faker _faker;

        public CustomerEntityTest()
        {
            _faker = new Faker("pt_BR");
        }

        [Fact]
        public void Should_Throw_Exception_When_Name_Is_Empty()
        {
            // Arrange
            var email = new Email(_faker.Internet.Email());
            var cpf = new CPF(_faker.Person.Cpf());

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => new CustomerEntity(string.Empty, email, cpf));
        }

        [Fact]
        public void Should_Throw_Exception_When_Email_Is_Null()
        {
            // Arrange
            var name = _faker.Name.FullName();
            var cpf = new CPF(_faker.Person.Cpf(false));

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => new CustomerEntity(name, null, cpf));
        }

        [Fact]
        public void Should_Throw_Exception_When_CPF_Is_Null()
        {
            // Arrange
            var name = _faker.Name.FullName();
            var email = new Email(_faker.Internet.Email());

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => new CustomerEntity(name, email, null));
        }
    }
}
