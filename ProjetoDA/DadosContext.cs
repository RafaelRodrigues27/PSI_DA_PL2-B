using ProjetoDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProjetoDA.dbcontext
{
    public class DadosContext : DbContext
    {
        public DbSet<funcionario> Funcionarios { get; set; }
        public DbSet<estudante> Estudantes { get; set; }
        public DbSet<professor> Professores { get; set; }
        public DbSet<prato> Pratos { get; set; }
        public DbSet<extras> Extras { get; set; }
        public DbSet<multa> Multas { get; set; }
        public DbSet<menu> Menus { get; set; }
        public DbSet<reserva> Reservas { get; set; }
        public DbSet<fatura> Faturas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Custom configurations (if any)
        }
    }
}
