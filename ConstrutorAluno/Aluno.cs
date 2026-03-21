using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        public string? nome;
        private static int contador;
        public long ra;
        private long NovoRa;
        static Aluno()
        {
            ra = 1570482421000;
        }










        public void MostrarAluno()
        {
            Console.WriteLine("Ra: "+ ra);
        }
    }


}