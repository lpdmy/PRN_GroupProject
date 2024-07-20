using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public async Task DeleteCustomer(Customer customer)
        {
            await CustomerDAO.Instance.DeleteCustomer(customer);
        }

        public async Task<Customer> GetCustomer(int id)
        {
            return await CustomerDAO.Instance.GetCustomer(id);
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await CustomerDAO.Instance.GetCustomers();
        }

        public async Task<Customer> LogIn(string userName, string password)
        {
           return await CustomerDAO.Instance.LogIn(userName, password);
        }

        public async Task<Customer> SignUp(Customer customer)
        {
            return await CustomerDAO.Instance.SignUp(customer);
        }

        public async Task UpdateCustomer(Customer customer)
        {
            await CustomerDAO.Instance.UpdateCustomer(customer);
        }
    }
}
