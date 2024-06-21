using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Model
{
    public class funcionario
    {
        [Key]
        public int Idfuncionario { get; set; }
        public string Id { get; set; }

        public string Nome { get; set; }

        public string NIF { get; set; }
        public string Username { get; set; }

        public static BindingList<funcionario> Funcionario { get; } = new BindingList<funcionario>();

        public funcionario(string nome, string nif, string id, string username)
        {
            Nome = nome;
            NIF = nif;
            Username = username;
            Id = id;
            Funcionario.Add(this);

        }
        public override string ToString()
        {
            return $"{Nome} | {NIF}| {Id}| {Username}"; 
        }
    }
}
