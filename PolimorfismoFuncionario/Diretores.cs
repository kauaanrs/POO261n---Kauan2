using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Diretores : Funcionario
    {
        public Diretores(double salario) : base(salario)
        {
        }

        public override double CalcularBonificacao()
        {
            return base.CalcularBonificacao() + 1000; 
        }
    }
}