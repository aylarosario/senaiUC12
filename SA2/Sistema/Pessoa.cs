using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public abstract class Pessoa
    {
        public string nome {get; set;}

        public Endereco? endereco { get; set; }

        public bool enderecoComercial { get; set; }

        public abstract float PagarImposto(float rendimento);
    }
}