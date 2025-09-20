using EasyManagerApp.API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyManagerApp.API.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Group> Groups { get; set; }
    }
}
