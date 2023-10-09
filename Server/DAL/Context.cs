using Microsoft.EntityFrameworkCore;

namespace Yokaira_Parcial1.Server.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }      
    }
}
