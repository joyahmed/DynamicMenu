using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DynamicMenu.Models
{
    public class SubMenu
    {
        public int Id { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int MainMenuId { get; set; }


        [Display(Name = "Parent")]
        public string TopMenuSelector { get; set; }


        [Display(Name = "Item One Name")]
        public string SubMenuName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }


        //[Display(Name = "Item Two Name")]
        //public string SubMenuTwoName { get; set; }
        //public string ControllerTwoName { get; set; }
        //public string ActionTwoName { get; set; }


        //[Display(Name = "Item Three Name")]
        //public string SubMenuThreeName { get; set; }
        //public string ControllerThreeName { get; set; }
        //public string ActionThreeName { get; set; }


        //[Display(Name = "Item Four Name")]
        //public string SubMenuFourName { get; set; }
        //public string ControllerFourName { get; set; }
        //public string ActionFourName { get; set; }

        //[Display(Name = "Item Five Name")]
        //public string SubMenuFiveName { get; set; }
        //public string ControllerFiveName { get; set; }
        //public string ActionFiveName { get; set; }

        //[Display(Name = "Item Six Name")]
        //public string SubMenuSixName { get; set; }
        //public string ControllerSixName { get; set; }
        //public string ActionSixName { get; set; }

        //[Display(Name = "Item Seven Name")]
        //public string ControllerSevenName { get; set; }
        //public string ActionSevenName { get; set; }
        //public string SubMenuSevenName { get; set; }

        //[Display(Name = "Item Eigth Name")]
        //public string SubMenuEightName { get; set; }
        //public string ControllerEightName { get; set; }
        //public string ActionEightName { get; set; }

        //[Display(Name = "Item Nine Name")]
        //public string SubMenuNineName { get; set; }
        //public string ControllerNineName { get; set; }
        //public string ActionNineName { get; set; }


        //[Display(Name = "Item Ten Name")]
        //public string SubMenuTenName { get; set; }
        //public string ControllerTenName { get; set; }
        //public string ActionTenName { get; set; }

        //public MainMenu MainMenu { get; set; }
    }
}
