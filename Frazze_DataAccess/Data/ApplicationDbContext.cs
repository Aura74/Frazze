using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Frazze_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
        public DbSet<Phrases> Phrases { get; set; }
        public DbSet<Applications> Application { get; set; }
        public DbSet<Cultures> Culture { get; set; }
        public DbSet<Pages> Page { get; set; }
    }
}
