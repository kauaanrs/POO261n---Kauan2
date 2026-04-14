using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente
    {
        protected int codigo;
        protected string? nome;
        protected string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        
        public int codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}