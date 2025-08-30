// Controlar o acesso a uma pasta compartilhada a usuários de uma empresa usando o padrão Proxy

using Proxy1;

Console.WriteLine("### Exemplo de implementação de padrão Proxy ###\n");

//Acesso do Programador
Console.WriteLine("\nFuncionário com perfil 'Programador' acessnado a Pasta Compartilhada Proxy");

Funcionario programador = new Funcionario("Enivaldo", "Programador");
PastaCompartilhadaProxy pastaCompartilhadaProxy1 = new(programador);
pastaCompartilhadaProxy1.OperacaoDeLeituraGravacao();

//Acesso do CEO
Console.WriteLine("\nFuncionário com perfil 'CEO' acessnado a Pasta Compartilhada Proxy");
Funcionario ceo = new Funcionario("Lana", "ceo");
PastaCompartilhadaProxy pastaCompartilhadaProxy2 = new(ceo);
pastaCompartilhadaProxy2.OperacaoDeLeituraGravacao();

//Acesso do Usuario
Console.WriteLine("\nFuncionário com perfil 'Usuario' acessnado a Pasta Compartilhada Proxy");
Funcionario usuario = new Funcionario("Lana", "usuario");
PastaCompartilhadaProxy pastaCompartilhadaProxy3 = new(usuario);
pastaCompartilhadaProxy3.OperacaoDeLeituraGravacao();


Console.ReadKey();