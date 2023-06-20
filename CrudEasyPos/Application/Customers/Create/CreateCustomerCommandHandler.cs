using Domain.Customer;
using Domain.Primitives;
using Domain.ValueObjects;
using MediatR;

namespace Application.Customers.Create;

internal sealed class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Unit>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IUnitOfWork _unitOfWork;
    public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
    {
        _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
    }
    public async Task<Unit> Handle(CreateCustomerCommand command,  CancellationToken cancellationToken)
    {
        if(PhoneNumber.Create(command.PhoneNumber) is not PhoneNumber phoneNumber)
        {
            throw new ArgumentException(nameof(phoneNumber));
        }

        if(Address.Create(command.Country, command.Linea1, command.Linea2, command.City, 
            command.State, command.ZipCode) is not Address address)
        {
            throw new ArgumentException(nameof(adrress));
        }

        var Customer = new Customer(
            new CustomerId(Guid.NewGuid()),
            command.Name,
            command.LastName,
            command.Email,
            phoneNumber,
            address,
            true
        );
    
    await _customerRepository.Add(Customer);

    await _unitOfWork.SaveChangesAsync(cancellationToken);

    return Unit.Value;
    
    }

    private object adrress()
    {
        throw new NotImplementedException();
    }
}




