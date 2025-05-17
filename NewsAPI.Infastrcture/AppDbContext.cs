using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsAPI.Domain.AppEntity;

namespace NewsAPI.Infastrcture
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            
        }

        public DbSet<Banners> Banners {  get; set; }
        public DbSet<Category> Category {  get; set; }
        public DbSet<News> News {  get; set; }
    }
}
