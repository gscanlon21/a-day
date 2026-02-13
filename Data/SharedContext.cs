using Microsoft.EntityFrameworkCore;
using ADay.Data.Entities.Footnote;

namespace ADay.Data;

/// <summary>
/// https://mehdi.me/ambient-dbcontext-in-ef6/
/// </summary>
public class SharedContext : DbContext
{
    [Obsolete("Public parameterless constructor required for EF Core.", error: true)]
    public SharedContext() : base() { }
    public SharedContext(DbContextOptions<SharedContext> context) : base(context) { }

    public DbSet<Footnote> Footnotes { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}
