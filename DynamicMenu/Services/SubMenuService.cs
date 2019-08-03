using DynamicMenu.Data;
using DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMenu.Services
{
    public class SubMenuService : ISubMenuService
    {
        private readonly ApplicationDbContext _context;

        public SubMenuService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SubMenu> GetSubMenu()
        {
            return _context.SubMenu.AsEnumerable();

        }
    }
}
