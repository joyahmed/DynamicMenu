using System;
using System.Collections.Generic;
using System.Text;
using DynamicMenu.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DynamicMenu.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MainMenu> MainMenu { get; set; }
        public DbSet<SubMenu> SubMenu { get; set; }

    }
}
