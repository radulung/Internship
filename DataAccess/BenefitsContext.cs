using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class BenefitsContext : DbContext
    {
        public BenefitsContext(DbContextOptions<BenefitsContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
