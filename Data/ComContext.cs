using Microsoft.EntityFrameworkCore;
using Shared.Data.Entities.Footnote;

namespace Shared.Data;

/// <summary>
/// https://mehdi.me/ambient-dbcontext-in-ef6/
/// </summary>
public class ComContext : DbContext
{
    [Obsolete("Public parameterless constructor required for EF Core.", error: true)]
    public ComContext() : base() { }
    public ComContext(DbContextOptions<ComContext> context) : base(context) { }

    public DbSet<Footnote> Footnotes { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}
