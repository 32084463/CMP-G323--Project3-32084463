using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DeviceManagement_WebApp.Repository
{
    public class CategoryRepository 
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        //GET CATEGORIES

        public List<Category> GetAll()
        {
            return _context.Category.ToList();
        }

        //GET CATEGORY BY ID

        public async Task<Category> Getby(Guid? id)
        {
            var category = await _context.Category.FirstOrDefaultAsync(m => m.CategoryId == id);
            return (category);
        }
    }
}
