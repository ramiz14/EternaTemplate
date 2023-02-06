using Microsoft.EntityFrameworkCore;

namespace EternaTemplate.DataAccessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }
    }
}
