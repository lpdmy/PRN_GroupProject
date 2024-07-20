using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerDAO : SingletonBase<CustomerDAO>
    {
        public async Task<Customer> LogIn(string userName, string password)
        {
            Customer customer;
            try
            {
                customer = await _context.Customers.FirstOrDefaultAsync(x => x.UserName.Equals(userName) && x.Password.Equals(password));
                if (customer == null)
                {
                    throw new Exception("Password or username is wrong");
                }
                else if (customer.IsDisabled == true)
                {
                    throw new Exception("You are disabled");
                }
                else {
                    return customer;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Customer> SignUp(Customer customer)
        {
            try
            {
                await _context.Customers.AddAsync(customer);
                await _context.SaveChangesAsync();
                return customer;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task DeleteCustomer(Customer customer)
        {
            try
            {
                _context.Remove(customer);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task UpdateCustomer(Customer customer)
        {
            try
            {
                _context.Customers.Update(customer);

                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<Customer> GetCustomer(int id)
        {
            var customer = new Customer();
            try
            {
                customer = await _context.Customers.SingleOrDefaultAsync(c => c.CustomerId == id);
                return customer!;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            List<Customer> customers;
            try
            {
                customers = await _context.Customers.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customers;
        }

    }
}
