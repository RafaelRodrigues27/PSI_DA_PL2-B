﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Model
{
    public class itemfatura
    {
        [Key]
        public int Iditemfatura { get; set; }
        public string Descricao { get; set; }

        public double preco { get; set; }

    }
}
