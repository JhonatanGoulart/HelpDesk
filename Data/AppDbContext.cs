using Microsoft.EntityFrameworkCore;
using HelpDeskPro.API.Models;

namespace HelpDeskPro.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Chamado> Chamados { get; set; }  // Adicionando o DbSet para Chamado
    }
}
