using Data;
using Models;
using System.Collections;

namespace EcoPower_Logistics.Repository
{
    public class ProductRepository
    {
        protected readonly SuperStoreContext _storeContext = new SuperStoreContext();

        public async IEnumerable<Product> GetAll()
        { 
            return _storeContext.Products.ToList();
        }
    }
}
 