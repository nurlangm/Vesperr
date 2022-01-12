using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VesterrCFDatabase.Models;

namespace VesterrCFDatabase.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Entrance> SiteEntrance { get; set; }
        public DbSet<ServiceCard> ServiceCards { get; set; }
        public DbSet<ServiceIcon> ServiceIcons { get; set; }
        public DbSet<PortfolioCard> PortfolioCards { get; set; }
        public DbSet<PortfolioCategory> PortfolioCategories { get; set; }
        public DbSet<PortfolioCardCategory> PortfolioCardCategories { get; set; }
    }
}
