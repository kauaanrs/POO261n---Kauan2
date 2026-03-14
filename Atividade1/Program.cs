//main
using Atividade1; 

Estudante a1 = new Estudante();
Console.WriteLine("Digite o nome do aluno: ");
a1.Nome = Console.ReadLine();
Console.WriteLine("Digite a média do aluno: ");
a1.Media = Convert.ToDouble(Console.ReadLine());

Estudante a2 = new Estudante();
Console.WriteLine("Digite o nome do aluno: ");
a2.Nome = Console.ReadLine();
Console.WriteLine("Digite a média do aluno: ");
a2.Media = Convert.ToDouble(Console.ReadLine());

a1.MostrarAtributos();
a1.ExibirInformacoes();

Console.WriteLine();

a2.MostrarAtributos();
a2.ExibirInformacoes();

