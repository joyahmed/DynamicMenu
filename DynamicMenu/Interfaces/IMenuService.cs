using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicMenu.Models
{
    public interface IMenuService
    {
		IEnumerable<MainMenu> GetMenu();
	}
}
