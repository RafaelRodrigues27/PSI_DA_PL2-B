using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Model
{
    public class multa
    {
        [Key]
        public int Idmenu { get; set; }
        public int Valor { get; set; }

        public double NumHoras { get; set; }

        public static BindingList<multa> Multa { get; } = new BindingList<multa>();

        public multa(int valor, double numhoras)
        {
            Valor = valor;
            NumHoras = numhoras;
            Multa.Add(this);

        }

    }
}
