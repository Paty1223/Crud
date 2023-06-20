namespace Domain.Customer;

public interface ICustomerRepository
{
    Task<Customer?> GetByIdAsync(Customers.CustomerId id);
    Task Add(Customer customer);
}