using OrgOffering.Data;
using OrgOffering.Models;

namespace OrgOffering.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(CMPG323_HomeworkContext context) : base(context)
        {
        }

        public Product GetMostRecentProduct()
        {
            return _context.Products.OrderByDescending(product => product.CreatedDate).FirstOrDefault();
        }
    }
}
