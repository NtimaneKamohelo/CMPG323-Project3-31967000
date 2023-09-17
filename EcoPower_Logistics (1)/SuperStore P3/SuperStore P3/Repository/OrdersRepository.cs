using Data;
using Models;
using System.Collections;

namespace EcoPower_Logistics.Repository
{
    public class OrdersRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }
    }
}
