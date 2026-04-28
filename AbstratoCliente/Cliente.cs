using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public abstract class Cliente
    {//abstract não deixa instanciar 
        protected int codigo;
        protected string? nome;
        private int idade;
        protected Endereco endereco;

        
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
        public Endereco _Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public Cliente(int codigo, string? nome, int idade)
        {
            codigo = codigo; 
            Nome = nome; 
            Idade = idade; 
        }
        public abstract void VerificarIdade(); 
        public virtual void Mostrar()
        {
            Console.WriteLine("Nome: " + Nome + "\tIdade: "+ Idade);
        }
    }
}