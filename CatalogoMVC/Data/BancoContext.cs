using CatalogoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogoMVC.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { 
            
        }
        public DbSet<HomeModel> Users  { get; set; }
    }
}
