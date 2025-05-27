using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Presentation.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<EventEntity> Events { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<EventEntity>()
            .Property(e => e.Price)
            .HasPrecision(10, 2);

        base.OnModelCreating(modelBuilder);
    }
}