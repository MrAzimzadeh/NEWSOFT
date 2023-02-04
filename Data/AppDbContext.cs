using Microsoft.EntityFrameworkCore;
using NEWSOFT.Models;

namespace NEWSOFT.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Who> Whos { get; set; }
    public DbSet<Feature> Features { get; set; }
    
}