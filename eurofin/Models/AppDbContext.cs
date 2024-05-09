using eurofin.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace eurofin.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<NumberDisplay> NumberDisplays { get; set; }
    }
}
