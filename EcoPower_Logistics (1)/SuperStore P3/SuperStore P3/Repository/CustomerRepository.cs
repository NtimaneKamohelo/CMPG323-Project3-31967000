using Data;
using Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using EcoPower_Logistics.Repository;

namespace EcoPower_Logistics.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public CustomerRepository()
        {
            
        }

        public CustomerRepository(SuperStoreContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

   

        public Customer GetMostRecentCustomer()
        {
            return _context.Customers.OrderByDescending(Customer => Customer.CustomerName).FirstOrDefault();
        }

    }
}
