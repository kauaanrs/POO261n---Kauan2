using AgregacaoVetorConta; 

Cliente cli1 = new Cliente();
cli1.Nome = "Dani";
cli1.Rg = 111;
cli1.Telefone = 1899999999;


Cliente cli2 = new Cliente();
cli2.Nome = "Kauan";
cli2.Rg = 121411;
cli2.Telefone = 1287481741;


Conta c1 = new Conta();
c1.Numero = 1; 
c1.Saldo = 12414; 
c1.VetTitular = new List <Cliente>();
c1.VetTitular.Add(cli1);
c1.VetTitular.Add(cli2);
foreach (var item in c1.VetTitular)
{
    item.MostrarAtributos();
}


