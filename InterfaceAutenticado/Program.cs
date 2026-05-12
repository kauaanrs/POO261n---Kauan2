using InterfaceAutenticado;

// isto é um erro IAutenticavel ia = new IAutenticavel();

IAutenticavel ia; 
Gerente g = new Gerente();
g.Senha = 123; 
ia = g; 
ia.Autenticar(123);

Diretor d = new Diretor();
d.Senha = 100; 
ia = d; 
ia.Autenticar(100);

Cliente c = new Cliente();
c.Senha = 321; 
ia = c; 
Console.WriteLine(ia.Autenticar(321));