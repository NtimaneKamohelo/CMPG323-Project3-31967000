using Data;
using EcoPower_Logistics.Data;
using Microsoft.EntityFrameworkCore;
//using EcoPower_Logistics.Models;
using Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EcoPower_Logistics.Repository
{
    public class ProductRepository 
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        // GET BY ID: Product

        public Product Get(int id)
        {
            return _context.Products.Find(id);
        }

        //CREATE: Order

        public void Create(Product Products)
        {
            if (Products == null)
            {
                throw new ArgumentNullException(nameof(Products));
            }
            _context.Products.Add(Products);
            _context.SaveChanges();

        }

        //EDIT: Order
        public void Edit(Product Products)
        {
            if (Products == null)
            {
                throw new ArgumentNullException(nameof(Products));
            }
            _context.Entry(Products).State = EntityState.Modified;
            _context.SaveChanges();
        }

        //DELETE: Order
        public void delete(int id)
        {
            var Products = _context.Products.Find(id);
            if (Products != null)
            {
                _context.Products.Remove(Products);
                _context.SaveChanges();
            }
        }

        //Exists: Order
        public bool Exists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }

    }
}
