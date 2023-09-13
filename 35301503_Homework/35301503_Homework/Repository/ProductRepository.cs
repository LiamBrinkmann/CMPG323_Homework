using _35301503_Homework.Data;
using _35301503_Homework.Models;
using System.Collections;
using System.Linq;

namespace _35301503_Homework.Repository
{
    public class ProductRepository
    {
        protected readonly CMPG323_HomeworkContext _context = new CMPG323_HomeworkContext();

        //GET ALL: Products
        public IEnumerable<Product> GetAll()
        {
            return _context.Product.ToList();
        }
    }
}
