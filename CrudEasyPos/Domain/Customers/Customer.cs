using Domain.Customers;
using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Customer;

public sealed class Customer : AggregateRoot
{
    public Customer(CustomerId id, string name, string lasname, string email, PhoneNumber phoneNumber, Address address, bool active)
    {
        Id = id;
        Name = name;
        LastName = lasname;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;
        Active = active;
    }

    private Customer()
    {
        
    }

    
    public Customer Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName => $"{Name} {LastName}";
    public string Email { get; private set; } = string.Empty;
    public PhoneNumber PhoneNumber { get; private set; } 
    public Address Address { get; private set; }
    public bool Active { get; set; }
    public object Value { get; set; }

    public static implicit operator Customer(CustomerId v)
    {
        throw new NotImplementedException();
    }
} 