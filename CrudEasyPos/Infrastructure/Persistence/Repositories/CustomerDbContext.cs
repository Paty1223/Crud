using Domain.Customer;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly ApplicationDbContext _context;

    public CustomerRepository(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task Add(Customer customer) => await _context.Customers.AddAsync(customer);
    public async Task<Customer?> GetByIdAsync(Customer id) => await _context.Customers.SingleOrDefaultAsync(c => c.Id == id);

    public Task<Customer?> GetByIdAsync(CustomerId id)
    {
        throw new NotImplementedException();
    }
}

