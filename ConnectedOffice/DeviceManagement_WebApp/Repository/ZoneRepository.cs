using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        //Get Zone
        public IEnumerable<Zone> GetAll()
        {
            return _context.Zone.ToList();
        }
        //Get Zone ID

        public async Task<Zone> GetBy(Guid? id)
        {
            var zone = await _context.Zone.FirstOrDefaultAsync(m => m.ZoneId == id);
            return (zone);
        }

    }
}
