using Microsoft.EntityFrameworkCore;
using System;
using UrnaEstudantil.Data.Map;
using UrnaEstudantil.Domain;

namespace UrnaEstudantil.Data
{
    public class UrnaEstudantilContexto : DbContext
    {
        //public UrnaEstudantilContexto(DbContextOptions options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JETDHQT\\SQLEXPRESS; DataBase=UrnaEstudantil; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
