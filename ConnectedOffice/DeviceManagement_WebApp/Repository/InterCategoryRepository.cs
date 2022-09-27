using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class InterCategoryRepository : GenericRepository<Category>, 
    ICategory
    {
        public InterCategoryRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Category GetMostRecentService()
        {
            return _context.Category.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }
    }



}
