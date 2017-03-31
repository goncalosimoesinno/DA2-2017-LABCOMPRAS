using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2017_LABCOMPRAS.Models
{
    public class Despesa
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double valor { get; set; }
        public string Categoria { get; set; }
        public bool Pago { get; set; }

        public Despesa()
        { }
        public Despesa(string Nome,int Quantidade,string Categoria)
        { }
    }
    
    }

