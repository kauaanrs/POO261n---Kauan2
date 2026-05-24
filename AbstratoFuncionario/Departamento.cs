using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Departamento
    {
        protected int codigo;
        protected string? descricao;
        protected List<Funcionario> funcionarios = new List<Funcionario>();

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string? Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Departamento(int codigo, string? descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public double CalcularFolhaPagamento(int diasUteis)
        {
            double total = 0;
            foreach (Funcionario f in funcionarios)
            {
                total += f.CalcularSalario(diasUteis);
            }
            return total;
        }

        public void AdmitirFuncionario(Funcionario novoFuncionario)
        {
            funcionarios.Add(novoFuncionario);
        }

        public void DemitirFuncionario(int codigoDoFuncionario)
        {
            Funcionario? func = funcionarios.Find(f => f.Codigo == codigoDoFuncionario);
            if (func != null)
            {
                funcionarios.Remove(func);
                Console.WriteLine($"Funcionário {func.Nome} demitido com sucesso.");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }

        public void ListarNomeFuncionarioESalario()
        {
            Console.WriteLine($"Departamento: {Descricao}");
            foreach (Funcionario f in funcionarios)
            {
                f.Mostrar();
            }
        }

        public void MostrarQtdeDependentesFuncionario()
        {
            Console.WriteLine($"Quantidade de dependentes por funcionário - Departamento: {Descricao}");
            foreach (Funcionario f in funcionarios)
            {
                Console.WriteLine($"  {f.Nome}: {f.CalcularTotalDependente()} dependente(s)");
            }
        }
    }
}
