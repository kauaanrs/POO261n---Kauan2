using AbstratoFuncionario;


Assalariado a1 = new Assalariado(1, "Kauan", 10000);
Assalariado a2 = new Assalariado(2, "Adrian", 10000);

Comissionado c1 = new Comissionado(3, "Leo", 1000, 20);
Comissionado c2 = new Comissionado(4, "Gabriel", 1000, 30);


Dependente dep1 = new Dependente(1, "Lucas", 15);
Dependente dep2 = new Dependente(2, "Maria", 20);
Dependente dep3 = new Dependente(3, "Ana", 10);
Dependente dep4 = new Dependente(4, "Pedro", 25);


a1.AdicionarDependente(dep1);
a1.AdicionarDependente(dep2);

a2.AdicionarDependente(dep3);

c1.AdicionarDependente(dep4);


Departamento d1 = new Departamento(1, "TI");
d1.AdmitirFuncionario(a1);
d1.AdmitirFuncionario(a2);
d1.AdmitirFuncionario(c1);
d1.AdmitirFuncionario(c2);

Console.WriteLine("Lista de funcionários: ");
d1.ListarNomeFuncionarioESalario();

Console.WriteLine("\nDependentes por funcionários: ");
a1.ListarDependentes();
Console.WriteLine();
a2.ListarDependentes();
Console.WriteLine();
c1.ListarDependentes();
Console.WriteLine();
c2.ListarDependentes();

Console.WriteLine("\nDependentes por funcionário por depertamento: ");
d1.MostrarQtdeDependentesFuncionario();


a1.RemoverDependentesMaioridade(2);
a1.ListarDependentes();

a1.RemoverDependentesMaioridade(1);

Console.WriteLine("\nFolha de pagamento: ");
Console.WriteLine($"Total: {d1.CalcularFolhaPagamento(22):c}");
