namespace Domain.Customers;

public record CustomerId(Guid Value)
{
    private object value;

    public CustomerId(object value)
    {
        this.value = value;
    }
}
