using Data;
using Models;
using System.Collections;

namespace EcoPower_Logistics.Repository
{
    public class OrderDetailsRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public IEnumerable<OrderDetail> GetAll()
        {
            return _context.OrderDetails.ToList();
        }
    }
}
