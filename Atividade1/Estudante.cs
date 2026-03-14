using System;
using System.Collections.Generic;
using System.Linq;
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
                return this.nome.ToUpper;
            }
        }

        public double media
        {
            set
            {
                if (media < 0 || media > 10)
                    Console.WriteLine("Valor inválido para média !");
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
            Console.WriteLine("Nome do Aluno: " + nome + "\tMédia: " + media);
        }

        public bool EstaAprovado(media)
        {
            if (media < 6)
                return false;

            else
                return true;
        }
    }
}