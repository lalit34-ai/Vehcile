using Microsoft.EntityFrameworkCore;
using VEHCILE.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace VEHCILE.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Employees> Employees { get; set; }

    public DbSet<Bus>? Buses { get; set; }
    public DbSet<Bookebususer> CustomerRequest { get; set; }

    public DbSet<Bookcaruser> CustomerCar { get; set; }

    public DbSet<Feedback> Feedback { get; set; }
    public DbSet<Car> Cars { get; set; }
}
