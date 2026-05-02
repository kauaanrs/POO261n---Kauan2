using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;
        public double TotalBonificacao
        {
            get
            { 
                return totalBonificacao; 
            }
            set
            {
                totalBonificacao = value;     
            }
        }
        
        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            totalBonificacao += funcionario.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Secretario secretario)
        {
            totalBonificacao += secretario.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Gerente gerente)
        {
            totalBonificacao += gerente.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Diretores diretores)
        {
            totalBonificacao += diretores.CalcularBonificacao();
        }
    }
}