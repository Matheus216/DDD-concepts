namespace API.Domain.ObjectValues;
public class CPF
{
    public string Value { get; private set; }

    public CPF(string value)
    {
        Value = value.Replace(".", "").Replace("-", "").Trim();
        IsValid();
    }

    private void IsValid()
    {
        if (string.IsNullOrEmpty(Value))
        {
            throw new InvalidOperationException("CPF can't be empty");
        }
        if (Value.Length != 11)
        {
            throw new InvalidOperationException("CPF must have 11 characters");
        }
    }
}