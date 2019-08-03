using DynamicMenu.Data;
using DynamicMenu.Models;
using System.Collections.Generic;
using System.Linq;



namespace DynamicMenu.Services
{
    public class MenuService : IMenuService
    {
		private readonly ApplicationDbContext _context;

		public MenuService(ApplicationDbContext context)
		{
			_context = context;
		}

        public IEnumerable<MainMenu> GetMenu()
        {
            return _context.MainMenu.AsEnumerable();

        }
    }
}
