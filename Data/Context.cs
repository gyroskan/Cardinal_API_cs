using Microsoft.EntityFrameworkCore;
using Cardinal_api.Models;

namespace Cardinal_api.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Guild> Guilds { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .HasKey(m => new { m.ID, m.GuildID__ });

            modelBuilder.Entity<Member>()
                .HasOne<Guild>(m => m.guild)
                .WithMany(g => g.Members)
                .HasForeignKey(m => m.GuildID__);

            modelBuilder.Entity<Guild>()
                .HasKey(g => g.ID);
        }
    }
}