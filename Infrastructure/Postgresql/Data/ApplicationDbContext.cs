using Application.Abstractions.Data;
using Domain.Users;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Postgresql.Data;

internal sealed class ApplicationDbContext : DbContext, IApplicationDbContext
{
    
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
}