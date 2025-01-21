namespace API.Domain.ObjectValues
{
    public class Email
    {
        public string Value { get; private set; }

        public Email(string value)
        {
            Value = value;
            IsValid();
        }

        private void IsValid()
        {
            if (string.IsNullOrEmpty(Value))
            {
                throw new InvalidOperationException("Email can't be empty");
            }
            if (!Value.Contains("@"))
            {
                throw new InvalidOperationException("Email must contain @");
            }
        }
    }
}