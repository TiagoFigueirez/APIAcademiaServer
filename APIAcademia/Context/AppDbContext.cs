using Microsoft.EntityFrameworkCore;

namespace APIAcademia.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            
        }
    }
}
