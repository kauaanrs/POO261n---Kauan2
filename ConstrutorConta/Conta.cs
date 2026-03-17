using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        private int numero;
        private string? titular;

        private double saldo;

        public Conta() //construtor padrão
        { // não tem parametro e é concedido automaticamente pela classe
        }

        public Conta(int numero)
        { //  atributo = parâmetro
            this.numero = numero;
        }
        public Conta(string? titular, double saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero +
                        "\tTitular: " + titular +
                        "\tSaldo: " + saldo);
        }
    }//
}