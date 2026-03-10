using EncapsulamentoConta;
Conta c = new Conta();
c.Numero = 1; //setNumero
Console.WriteLine("Numero da conta: " + c.Numero); //getNumero
c.Sacar(10);
c.MostrarAtributos();
//if (c.Numero > 5)
//x = c.Numero + 21; 