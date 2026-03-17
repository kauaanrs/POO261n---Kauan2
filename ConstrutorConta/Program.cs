using ConstrutorConta;

Conta c1 = new Conta(); //chamada do construtor padrão
c1.MostrarAtributos();

Conta c2 = new Conta(1);
c2.MostrarAtributos(); //chamada do construtor com 1 parametro

Conta c3 = new Conta("Ana", 100);
c3.MostrarAtributos();
Console.WriteLine("Quantidade: " + Conta.Contador);