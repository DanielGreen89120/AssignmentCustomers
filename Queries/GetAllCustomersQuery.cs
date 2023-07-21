using CustomerCRUD.Models;
using MediatR;

namespace CustomerCRUD.Queries
{
    public class GetAllCustomersQuery : IRequest<List<Customer>>
    {

    }
    
}
