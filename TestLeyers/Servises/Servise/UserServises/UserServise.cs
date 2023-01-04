using Microsoft.EntityFrameworkCore;
using TestLeyers.ApplicationDB;
using TestLeyers.Models;

namespace TestLeyers.Servises.Servise.UserServises
{
    public class UserServise : IUserServise
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<UserModel> _dbSet; 
        public UserServise(ApplicationDbContext context)
        {
            _context = context; 
            _dbSet = context.Set<UserModel>();  

        }
        public void Add(UserModel user)
        {
            _dbSet.Add(user);   
        }
    }
}
