using Microsoft.EntityFrameworkCore;

namespace ApiTask1.Models
{
    public class ModContext : DbContext
    {
        public ModContext(DbContextOptions<ModContext> options) : base(options)
        {

        }
        public DbSet<ModApi> TabT { get; set; }

    }
}
