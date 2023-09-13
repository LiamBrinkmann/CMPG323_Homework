using OrgOffering.Data;
using OrgOffering.Models;

namespace OrgOffering.Repository
{
    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        public ServiceRepository(CMPG323_HomeworkContext context) : base(context)
        {
        }

        public Service GetMostRecentService()
        {
            return _context.Services.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }
    }

}
