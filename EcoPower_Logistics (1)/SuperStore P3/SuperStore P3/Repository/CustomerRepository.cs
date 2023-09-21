using Data;
using Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using EcoPower_Logistics.Repository;

namespace EcoPower_Logistics.Repository
{
    public class CustomerRepository 
    {
        protected new readonly SuperStoreContext _context = new SuperStoreContext();

        public new IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        // GET BY ID: CUSTOMERS

        public Customer Get(int id)
        {
            return _context.Customers.Find(id);
        }

        //CREATE: CUSTOMER

        public void Create(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            _context.Customers.Add(customer);
            _context.SaveChanges();

        }

        //EDIT: Customer
        public void Edit(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();
        }

        //DELETE: Customer
        public void delete(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        //Exists: Customer
        public bool Exists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }


    }
}
