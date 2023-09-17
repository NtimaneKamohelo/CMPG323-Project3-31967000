using Data;
using EcoPower_Logistics.Data;
//using EcoPower_Logistics.Models;
using Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EcoPower_Logistics.Repository
{
    public class ProductRepository
    {
        protected readonly SuperStoreContext _Context = new SuperStoreContext();

        public IEnumerable<Product> GetAll()
        {
            return _Context.Products.ToList();
        }
    }
}
