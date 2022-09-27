using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceReprository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        //GET Devices
        public List<Device> GetAll()
        {
            return _context.Device.ToList();
        }

        //Get CategoryID

        public async Task<Device> GetBy(Guid? id)
        {
            var device = await _context.Device.FirstOrDefaultAsync(m => m.DeviceId == id);
            return (device);
        }
    }
}
