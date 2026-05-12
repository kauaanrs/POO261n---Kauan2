using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticado
{
    public class Cliente : IAutenticavel
    {
        public int Senha { get; set; }
        public bool Autenticar(int senha)
        {
            if (Senha == senha)
               {
                Console.WriteLine();
                return true; 
               } 
            return false; 
        }
    }
}