using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDA.Model
{
    public class extras
    {
        [Key]
        public int Idextras { get; set; }
        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public bool Ativo { get; set; }

        public static BindingList<extras> Extras { get; } = new BindingList<extras>();

        public extras(string descricao, decimal preco, bool ativo)
        {
            Descricao = descricao;
            Preco = preco;
            Ativo = ativo;
            Extras.Add(this);

        }
    }
}
