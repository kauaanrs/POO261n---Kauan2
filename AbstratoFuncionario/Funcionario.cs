using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        protected string? nome;
        protected double salario;
        protected int codigo;
        protected List<Dependente> dependentes = new List<Dependente>();

        public abstract double CalcularSalario(int diasUteis);

        public virtual void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo}  \tNome: {Nome}  Salario: {Salario:c}");
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public Funcionario(int codigo, string? nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public int CalcularTotalDependente()
        {
            return dependentes.Count;
        }

        public void AdicionarDependente(Dependente novoDep)
        {
            dependentes.Add(novoDep);
        }

        public void RemoverDependentesMaioridade(int codigo)
        {
            Dependente? dep = dependentes.Find(d => d.Codigo == codigo);
            if (dep != null && dep.VerificarMaioridade())
            {
                dependentes.Remove(dep);
                Console.WriteLine($"Dependente {dep.Nome} removido com sucesso.");
            }
            else if (dep == null)
            {
                Console.WriteLine("Dependente não encontrado.");
            }
            else
            {
                Console.WriteLine($"Dependente {dep.Nome} é menor de idade e não pode ser removido.");
            }
        }

        public void ListarDependentes()
        {
            if (dependentes.Count == 0)
            {
                Console.WriteLine($"{Nome} não possui dependentes.");
                return;
            }
            Console.WriteLine($"Dependentes de {Nome}:");
            foreach (Dependente dep in dependentes)
            {
                dep.Mostrar();
            }
        }
    }
}
