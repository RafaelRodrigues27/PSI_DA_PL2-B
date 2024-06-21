using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Model
{
    public class fatura
    {
        [Key]
        public int Idfatura { get; set; }
        public double total { get; set; }

        public DateTime DataHora { get; set; }
    }
}
