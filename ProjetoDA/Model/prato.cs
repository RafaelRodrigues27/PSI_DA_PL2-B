using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjetoDA.Model
{
    public class prato
    {
        [Key]
        public int Idprato { get; set; }
        public string Descricao { get; set; }

        public string Tipo { get; set; }

        public string Ativo { get; set; }

        public static BindingList<prato> Prato { get; } = new BindingList<prato>();

        public prato(string descricao, string tipo, string ativo)
        {
            Descricao = descricao;
            Tipo = tipo;
            Ativo = ativo;
            Prato.Add(this);

        }
    }
}
