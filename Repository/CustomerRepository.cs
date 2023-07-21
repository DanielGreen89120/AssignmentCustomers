using CustomerCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerCRUD.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly CustomerContext _dbContext;
        public CustomerRepository(CustomerContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Customer> GetAllCustomer()
        {
            //if (_dbContext.Customers == null)
            //{
            //    return NotFound();
            //}
            return await _dbContext.Customers.ToListAsync();
        }

        public Task<Customer> GetCustomerById(string id)
        {
            throw new NotImplementedException();
        }
        //public <IEnumerable<Customer>> GetCustomerAsync()
        //{
        //    //if (_dbContext.Customers == null)
        //    //{
        //    //    return NotFound();
        //    //}
        //    return await _dbContext.Customers.ToListAsync();
        //}
    }
}
