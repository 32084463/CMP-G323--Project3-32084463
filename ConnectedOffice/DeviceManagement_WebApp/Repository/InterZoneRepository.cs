using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class InterZoneRepository : GenericRepository<   Zone>,
    IZoneRepository
    {
        public InterZoneRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Zone GetMostRecentService()
        {
            return _context.Zone.OrderByDescending(Zone => Zone.CreatedDate).FirstOrDefault();
        }

        Zone IZoneRepository.GetMostRecentService()
        {
            throw new System.NotImplementedException();
        }
    }



}
