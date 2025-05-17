using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace NewsAPI.Domain.AppEntity
{
    public class Account : IdentityUser
    {
        public DateTime CreatAt { get; set; } = DateTime.Now;
    }
}
