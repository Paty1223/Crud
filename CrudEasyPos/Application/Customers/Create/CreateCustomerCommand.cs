using MediatR;

namespace Application.Customers.Create;

public record CreateCustomerCommand(
    string Name,
    string LastName,
    string Email,
    string PhoneNumber,
    string Country,
    string Linea1,
    string Linea2,
    string City,
    string State,
    string ZipCode
) : IRequest<Unit>;