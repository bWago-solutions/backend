
using Domain.Users;
using Infrastructure.Postgresql.Data;

namespace Infrastructure.Postgresql.Repositories;

internal sealed class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;
    public UserRepository(ApplicationDbContext context)
    {
        this._context = context;
    }
    
    public void Insert(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }
}