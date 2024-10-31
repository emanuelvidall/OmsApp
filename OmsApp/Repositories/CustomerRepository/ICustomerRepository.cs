using OmsApp.Entities;

namespace OmsApp.Repositories.CustomerRepository;

public interface ICustomerRepository
{
    Task<Customer> GetCustomerByIdAsync(int id);
    Task<Customer> CreateCustomerAsync(Customer customer);
}