using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationsDBContext : DbContext
    {
        public ApplicationsDBContext(DbContextOptions<ApplicationsDBContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }

    }
}
