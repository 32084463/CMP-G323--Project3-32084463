using DeviceManagement_WebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();
        // GET: Devices
        public List<Device> GetAll()
        {
            return _context.Device.ToList();
        }
    }
}
