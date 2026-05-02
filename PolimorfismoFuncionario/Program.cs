using PolimorfismoFuncionario;

Funcionario f = new Funcionario(1000);
Console.WriteLine($"Funcionario {f.CalcularBonificacao():c}");

Secretario s = new Secretario(1000);
Console.WriteLine($"Secretario {s.CalcularBonificacao():c}");


Gerente g = new Gerente(1000);
Console.WriteLine($"Gerente {g.CalcularBonificacao():c}");


Diretores d = new Diretores(1000);
Console.WriteLine($"Diretor {d.CalcularBonificacao():c}");

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

gerenciador.TotalizadorBonificacao(f); 
gerenciador.TotalizadorBonificacao(s); 
gerenciador.TotalizadorBonificacao(g); 
gerenciador.TotalizadorBonificacao(d);

Console.WriteLine();
Console.WriteLine($"Total de bonificações: {gerenciador.TotalBonificacao:c}");