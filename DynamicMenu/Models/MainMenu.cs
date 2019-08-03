using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DynamicMenu.Models
{
    public class MainMenu
    {
        public int Id { get; set; }

        [Display(Name ="Name")]
        public string MenuName { get; set; }

        [Display(Name ="URL")]
        public string ControllerName { get; set; }

        [Display(Name ="File Name")]
        public string ActionName { get; set; }
        public List<SubMenu> SubMenu { get; set; }
    }
}
