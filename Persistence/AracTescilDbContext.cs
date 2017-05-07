using AracTescil.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracTescil.Persistence
{
    public class AracTescilDbContext : DbContext
    {
        public AracTescilDbContext(DbContextOptions<AracTescilDbContext> options)

            : base(options)
        {
        }
        public DbSet<Marka> Markalar { get; set; }
    }
}
    
