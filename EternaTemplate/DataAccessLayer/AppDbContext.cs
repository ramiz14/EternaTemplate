using EternaTemplate.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaTemplate.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> sliders { get; set; }
        public DbSet<Images> images { get; set; }

    }
}
