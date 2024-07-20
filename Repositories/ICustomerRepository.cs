using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> LogIn(string userName, string password);
        Task<Customer> SignUp(Customer customer);
        Task DeleteCustomer(Customer customer);
        Task UpdateCustomer(Customer customer);
        Task<Customer> GetCustomer(int id);
        Task<IEnumerable<Customer>> GetCustomers();
    }
}
