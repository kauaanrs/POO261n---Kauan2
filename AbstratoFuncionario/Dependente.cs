using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Dependente
    {
        protected int codigo;
        protected string? nome;
        protected int idade;

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

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public Dependente(int codigo, string? nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }

        public bool VerificarMaioridade()
        {
            return Idade >= 18;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo}  \tNome: {Nome}  Idade: {Idade}  Maior de idade: {(VerificarMaioridade() ? "Sim" : "Não")}");
        }
    }
}
