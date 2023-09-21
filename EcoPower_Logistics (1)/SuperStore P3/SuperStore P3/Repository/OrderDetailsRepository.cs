using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections;

namespace EcoPower_Logistics.Repository
{
    public class OrderDetailsRepository
    {
        protected new readonly SuperStoreContext _context = new SuperStoreContext();

        public new IEnumerable<OrderDetail> GetAll()
        {
            return _context.OrderDetails.ToList();
        }

        // GET BY ID: OrderDetails

        public OrderDetail Get(int id)
        {
            return _context.OrderDetails.Find(id);
        }

        //CREATE: OrderDetails

        public void Create(OrderDetail orderDetail)
        {
            if (orderDetail == null)
            {
                throw new ArgumentNullException(nameof(orderDetail));
            }
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();

        }

        //EDIT: OrderDetails
        public void Edit(OrderDetail orderDetail)
        {
            if (orderDetail == null)
            {
                throw new ArgumentNullException(nameof(orderDetail));
            }
            _context.Entry(orderDetail).State = EntityState.Modified;
            _context.SaveChanges();
        }

        //DELETE: OrderDetails
        public void delete(int id)
        {
            var orderDetail = _context.OrderDetails.Find(id);
            if (orderDetail != null)
            {
                _context.OrderDetails.Remove(orderDetail);
                _context.SaveChanges();
            }
        }

        //Exists: OrderDetails
        public bool Exists(int id)
        {
            return _context.OrderDetails.Any(e => e.OrderDetailsId == id);
        }

    }
}
