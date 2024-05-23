using Microsoft.EntityFrameworkCore;
using System;

public class SpendeeDbContext : DbContext
{
    // Standard constructor setup for Entity Framework Core to set up DbContext for DI and config.
    // 
    public SpendeeDbContext (DbContextOptions<SpendeeDbContext> options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Expense> Expenses { get; set; }

}
