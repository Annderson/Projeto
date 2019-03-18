using Microsoft.EntityFrameworkCore;

namespace projeto_lista.Entities
{
    public class NomeContext : DbContext
    {

        public NomeContext(DbContextOptions<NomeContext> options) : base(options) {
        }
        
        public DbSet<NomeItem> NomeItems { get; set; }
    }
}