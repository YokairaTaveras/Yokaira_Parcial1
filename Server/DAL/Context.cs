using Microsoft.EntityFrameworkCore;
using Yokaira_Parcial1.Server.Models;

namespace Yokaira_Parcial1.Server.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }
        public DbSet<Aportes> aporte { get; set; }
    }
}
