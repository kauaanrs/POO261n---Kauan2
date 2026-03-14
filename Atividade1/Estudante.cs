using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Atividade1
{
    public class Estudante
    {
        private string? nome;

        private double media; 


        public string? Nome
        {
            set
            {
                this.nome = value;
            }
            get
            {
                return this.nome.ToUpper();
            }
        }

        public double Media
        {
            set
            {
                if (media < 0 || media > 10)
                {
                    Console.WriteLine("Valor inválido para média !");
                }
                    
                else
                    this.media = value;
            }
            get
            {
                return this.media;
            }
        }


        //Funções 
        public void MostrarAtributos()
        {
            Console.WriteLine("Nome do Aluno: " + Nome + "\tMédia: " + Media);
        }

        public bool EstaAprovado()
        {
            if (Media >= 6 && Media <= 10)
                return true;

            else
                return false;
        }

        public void ExibirInformacoes()
        {
            string status = (EstaAprovado()) ? "Aprovado" : "Reprovado";
            Console.WriteLine("Status: " + status);
        }
    }
}