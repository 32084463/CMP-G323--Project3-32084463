using DeviceManagement_WebApp.Data;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;



namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

         // GET: Zones
        public List<Zone> GetAll()
        {
            return _context.Zone.ToList();
        }

    }
}
