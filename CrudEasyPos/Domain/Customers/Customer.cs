using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Customer;

public sealed class Customer : AggregateRoot
{
    public Customer Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName => $"{Name} {LastName}";
    public string Email { get; private set; } = string.Empty;
    public PhoneNumber PhoneNumber { get; private set; } 
    public Address Address { get; private set; }
    public bool Active { get; set; }
} 