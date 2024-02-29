using anccrud.Models.Domain;
using Microsoft.EntityFrameworkCore;
namespace anccrud.Data 
{
    public class MVCDataDbContext : DbContext
    {
        public MVCDataDbContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<Employee> Employees { get; set; }

    }

}