using CustomerCRUD.Models;

namespace CustomerCRUD.Repository
{
    interface ICustomerRepository
    {
        public List<Customer> GetAllCustomer();

        public Customer GetCustomerById(int id);
    }
}
