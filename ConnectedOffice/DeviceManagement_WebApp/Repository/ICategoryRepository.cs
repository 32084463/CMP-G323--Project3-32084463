using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public interface ICategory : IGenericRepository<Category>
    {
        Category GetMostRecentService();
    }


}
