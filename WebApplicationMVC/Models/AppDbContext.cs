using Microsoft.EntityFrameworkCore;
using System;

namespace WebApplicationMVC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Ürün> Ürünler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Marka> Markalar { get; set; }


    }
}
