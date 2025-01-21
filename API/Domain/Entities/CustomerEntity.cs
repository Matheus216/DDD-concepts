using API.Domain.ObjectValues;

namespace API.Domain.Entities;

public class CustomerEntity
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public Email Email { get; private set; }
    public CPF CPF { get; private set; }

    public CustomerEntity(string name, Email email, CPF cpf)
    {
        Name = name;
        Email = email;
        CPF = cpf;
        IsValid();
    }

    private void IsValid()
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new InvalidOperationException("Name can't be empty");
        }
        if (Email == null)
        {
            throw new InvalidOperationException("Email can't be null");
        }
        if (CPF == null)
        {
            throw new InvalidOperationException("CPF can't be null");
        }
    }
}
