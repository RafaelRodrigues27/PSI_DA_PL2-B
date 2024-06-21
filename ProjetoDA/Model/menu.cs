using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Model
{
    public class menu
    {
        [Key]
        public int Idmenu { get; set; }
        public DateTime DataHora { get; set; }

        public int QtdDisponivel { get; set; }

        public double Precoestudante { get; set; }

        public double PrecoProfessor { get; set; }

        public static BindingList<menu> Menu { get; } = new BindingList<menu>();

        public menu(DateTime datahora, int qtddisponivel, double precoestudante, double precoprofessor)
        {
            DataHora = datahora;
            QtdDisponivel = qtddisponivel;
            Precoestudante = precoestudante;
            PrecoProfessor = precoprofessor;
            Menu.Add(this);



        }
    }
}
