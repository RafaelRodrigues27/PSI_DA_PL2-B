using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDA.Model
{
    public class estudante
    {
        [Key]
        public int Idestudante { get; set; }
        public string Id { get; set; }

        public string Nome { get; set; }

        public string NIF { get; set; }

        public int Saldo { get; set; }

        public string Nestudante { get; set; }

        public static BindingList<estudante> Estudante { get; } = new BindingList<estudante>();

        public estudante(string id, string nome, string nif, int saldo, string nestudante)
        {
            Id = id;
            Nome = nome;
            NIF = nif;
            Saldo = saldo;
            Nestudante = nestudante;
            Estudante.Add(this);

        }

    }
}
