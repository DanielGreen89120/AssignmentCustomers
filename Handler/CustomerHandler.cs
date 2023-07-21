using CustomerCRUD.Models;
using CustomerCRUD.Repository;
using MediatR;

namespace CustomerCRUD.Handler
{
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, List<Customer>>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepo;

        public GetCustomersQueryHandler(ICustomerRepository customerRepo, IMapper mapper)
        {
            _customerRepo = customerRepo;
            _mapper = mapper;
        }

        public async Task<List<Customer>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            var booksList = await _customerRepo.GetAllCustomer();
            if (booksList == null)
                throw new Exception("No user found. Failed to get list.");

            //var bookDTOList = _mapper.Map<List<Book>, List<BookDto>>(booksList);
            return bookDTOList;
        }
    }
}
