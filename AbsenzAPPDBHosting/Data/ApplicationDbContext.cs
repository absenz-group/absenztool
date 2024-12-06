using AbsenzAPPDBHosting.Models;
using Microsoft.EntityFrameworkCore;

namespace AbsenzAPPDBHosting.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Absenzen> Absenzen { get; set; }
        public DbSet<Absenzgruende> Absenzgruende { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Eltern> Eltern { get; set; }
        public DbSet<Klassen> Klassen { get; set; }
        public DbSet<Lehrer> Lehrer { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<Schueler> Schueler { get; set; }
        public DbSet<CrossSchuelerEltern> CrossSchuelerEltern { get; set; }
    }
}
