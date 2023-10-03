using Microsoft.EntityFrameworkCore;
using QrCodeMenu.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrCodeMenu.DataAccessLayer.Concrate
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<ProfileImage> ProfileImages { get; set; }
    }
}
