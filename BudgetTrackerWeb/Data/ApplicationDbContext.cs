using BudgetTrackerWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetTrackerWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
