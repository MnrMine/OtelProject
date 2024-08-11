using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OtelRezervasyon.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.DataAccessLayer.Context
{
    public class HotelContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-34LNO3L\\MSSQLSERVER01;initial catalog=DbHotelRezervasyon;integrated Security=true;");
        }
        public DbSet<Rooms> Roomses { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<SearchRoom> SearchRooms { get; set; }

    }
}
