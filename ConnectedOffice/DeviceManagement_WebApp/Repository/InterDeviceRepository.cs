using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class InterDeviceRepository : GenericRepository<Device>,
    IDeviceRepository
    {
        public InterDeviceRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Device GetMostRecentService()
        {
            return _context.Device.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }
    }



}
