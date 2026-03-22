using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        private string? nome;
        private static int contador;
         public static long RaFixo;
        private long ra;
        static Aluno()
        {
            RaFixo = 1570482421000;
        }

        public static int Contador
        {
            get
            {
                return contador;
            }
        }
        public Aluno(string? nome)
        {
            this.nome = nome;
            contador++;
            ra = RaFixo + contador;
        }
        public string? Nome{
            set
            {
                this.nome = value;
            }
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Nome: {nome} \tRa: {ra}");
        }
    }
}