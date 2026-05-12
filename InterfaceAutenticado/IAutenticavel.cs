using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticado
{
    public interface IAutenticavel
    {//este método é implicitamente publico e abstrato
        bool Autenticar(int senha); 
    }
}