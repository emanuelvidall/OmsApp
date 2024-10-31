using OmsApp.DTOs.Customer;

namespace OmsApp.Services.CustomerService;

public interface ICustomerService
{
    Task<CustomerDto> GetCustomerByIdAsync(int id);
    Task<CustomerDto> CreateCustomerAsync(CreateCustomerDto createCustomerDto);
}