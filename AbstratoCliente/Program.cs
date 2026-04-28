using AbstratoCliente; 

//Cliente c = new Cliente(); da erro 

Endereco e = new Endereco("Rua Principal", 10, "Centro", "P. Venceslau"); 

ClienteFisico cf = new ClienteFisico(1, "Kauan", 22, 546817786);
cf._Endereco = e; 

Teste teste = new Teste(); 
teste.AvaliarIdadeCliente(cf); 

//ClienteJuridico cj = new ClienteJuridico(2, "Gerson LTDA");
