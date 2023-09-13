using OrgOffering.Models;

namespace OrgOffering.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Product GetMostRecentProduct();
    }
}
