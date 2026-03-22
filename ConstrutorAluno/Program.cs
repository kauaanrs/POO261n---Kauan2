using ConstrutorAluno;

Aluno[] VetAluno = new Aluno[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite o nome do aluno {i + 1}: ");
    string? nome = Console.ReadLine();
    VetAluno[i] = new Aluno(nome);
}

Console.WriteLine();

foreach (Aluno a in VetAluno)
{
    a.MostrarAtributos();
    Console.WriteLine();
}

