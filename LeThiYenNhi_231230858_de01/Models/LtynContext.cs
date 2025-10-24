using Microsoft.EntityFrameworkCore;

namespace LeThiYenNhi_231230858_de01.Models
{
    public class LtynContext : DbContext
    {
        public LtynContext(DbContextOptions<LtynContext> options) : base(options) { }
        public DbSet<LtynComputer> LtynComputers { get; set; }
    }
}
