using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
  public class LibraryContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Category> Categories { get; set; }//change this bad boy
    public DbSet<Item> Items { get; set; }//change this bad boy
    public DbSet<CategoryItem> CategoryItem { get; set; }//change this bad boy
    public LibraryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}