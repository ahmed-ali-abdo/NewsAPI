using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewsAPI.Domain.AppEntity;

namespace NewsAPI.Infastrcture
{
    public class IdentityDbContext : IdentityDbContext<Account>
    {
        public IdentityDbContext(DbContextOptions options) : base(options)
        {
        }
        
        DbSet<Account> Accounts { get; set; }


    }
}
