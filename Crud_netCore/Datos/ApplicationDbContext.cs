using Crud_netCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_netCore.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Libro> Libro { get; set; }
    }
}