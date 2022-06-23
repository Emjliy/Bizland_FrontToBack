using Bizland_FrontToBack.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bizland_FrontToBack.DAL
{
    public class AppDbContext:DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Introduction> Intro { get; set; }
    }
}
