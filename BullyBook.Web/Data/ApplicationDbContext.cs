using BullyBook.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace BullyBook.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }
     }
}
