using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public class Endereco
    {
        public string? Rua { get; set; }       

        public int Numero { get; set; }

        public string? Bairro { get; set; }

        public string? Cidade {get; set; }

        public Endereco(string? Rua, int Numero, string? Bairro, string? Cidade)
        {
            Rua = Rua; 
            Numero = Numero; 
            Bairro = Bairro; 
            Cidade = Cidade; 
        }
    }
}