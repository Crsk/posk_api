namespace posk_api.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    public class PoskContext : DbContext
    {
        public DbSet<Boleta> Boletas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;database=posk_db;uid=root;pwd=MyTempPass.12;");
    }
}