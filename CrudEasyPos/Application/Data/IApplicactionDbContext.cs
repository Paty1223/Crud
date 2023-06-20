using Domain.Customer;
using Microsoft.EntityFrameworkCore;

namespace Application.Data;

public interface IApplicationDbContex
{
    DbSet<Customer> Customers { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}