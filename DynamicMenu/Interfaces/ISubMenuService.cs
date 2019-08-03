using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMenu.Models
{
    public interface ISubMenuService
    {
        IEnumerable<SubMenu> GetSubMenu();
    }
}
