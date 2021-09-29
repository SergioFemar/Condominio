using Microsoft.EntityFrameworkCore;
using Projeto.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Contexto
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Condominio> Condominio { get; set; }
        public DbSet<Predio> Predio { get; set; }
        public DbSet<Proprietario> Proprietario {get; set; }
        public DbSet<Apartamento> Apartamento { get; set; }
        public DbSet<Morador> Morador { get; set; }
    }
}
