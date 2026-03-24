using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Cliente
    {
        public string? Nome { get; set; }
        //Estabelecimento de agregação 
        public int Rg { get; set; }
        public int Telefone { get; set; }

    }
}