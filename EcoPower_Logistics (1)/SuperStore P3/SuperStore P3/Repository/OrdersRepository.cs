using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections;
using static NuGet.Packaging.PackagingConstants;

namespace EcoPower_Logistics.Repository
{
    public class OrdersRepository 
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        // GET BY ID: Order

        public Order Get(int id)
        {
            return _context.Orders.Find(id);
        }

        //CREATE: Order

        public void Create(Order Orders)
        {
            if (Orders == null)
            {
                throw new ArgumentNullException(nameof(Orders));
            }
            _context.Orders.Add(Orders);
            _context.SaveChanges();

        }

        //EDIT: Order
        public void Edit(Order Orders)
        {
            if (Orders == null)
            {
                throw new ArgumentNullException(nameof(Orders));
            }
            _context.Entry(Orders).State = EntityState.Modified;
            _context.SaveChanges();
        }

        //DELETE: Order
        public void delete(int id)
        {
            var Orders = _context.Orders.Find(id);
            if (Orders != null)
            {
                _context.Orders.Remove(Orders);
                _context.SaveChanges();
            }
        }

        //Exists: Order
        public bool Exists(int id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }
    }
}
