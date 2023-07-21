using Microsoft.EntityFrameworkCore;

namespace CustomerCRUD.Models
{
    public class CustomerContext:DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options):base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
