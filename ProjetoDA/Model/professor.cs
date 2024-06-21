using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDA.Model
{
    public class professor
    {
        [Key]
        public int Idprofessor { get; set; }
        public string Id { get; set; }

        public string Nome { get; set; }

        public string NIF { get; set; }

        public int Saldo { get; set; }

        public string Email { get; set; }

        public static BindingList<professor> Professor { get; } = new BindingList<professor>();

        public professor(string id, string nome, string nif, int saldo, string email)
        {
            Id = id;
            Nome = nome;
            NIF = nif;
            Saldo = saldo;
            Email = email;
            Professor.Add(this);

        }
    }
}
