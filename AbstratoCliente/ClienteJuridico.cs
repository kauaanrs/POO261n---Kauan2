using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public class ClienteJuridico : Cliente
    {
        public int Cnpj { get; set; }

        public ClienteJuridico(int codigo, string? nome, int idade, int cnpj) : base(codigo, nome, idade)
        {
            Cnpj = Cnpj; 
        }

        public override void VerificarIdade()
        {
            if (Idade >= 50)
                Console.WriteLine("CJ - Idade validada");
        }
    }
    
}