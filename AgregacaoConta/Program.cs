using AgregacaoConta;

Cliente cli = new Cliente();
cli.Nome = "Kauan";
cli.Rg = 546817786;
cli.Telefone = 18997193153;

Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 1500.00;
//Titular é um atributo/propriedade que quando recebe o objeto cli, o Titular passará a ser um objeto Cliente
//e efetiva a agregação 
c1.Titular = cli;

Conta c2 = new Conta();
c2.Numero = 2;
c2.Saldo = 3400; 
c2.Titular = new Cliente();
c2.Titular.Nome = "Dani";
c2.Titular.Rg = 147817482;
c2.Titular.Telefone = 18996440068; 

