

using Microsoft.EntityFrameworkCore;
using TestLeyers.Models;

namespace TestLeyers.ApplicationDB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<UserModel> user { get; set; }  

    }
}
