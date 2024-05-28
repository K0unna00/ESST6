using ESST6.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ESST6.DAL.DBContext;

public class AppDBContext : IdentityDbContext<AppUser, IdentityRole, string>
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; }

    public DbSet<IdentityRole> Roles { get; set; }

    public DbSet<SoilVM> Soils { get; set; }

    public DbSet<BatteryVM> Batteries { get; set; }

    public DbSet<DashboardVM> Dashboards { get; set; }


}
