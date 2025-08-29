using Facade1;

// Cria uma instância do Facade
CreditoFacade concedeCreditoFacade = new CreditoFacade();

// Cria uma instância de um novo Cliente informando o nome
Cliente cliente = new Cliente("Enivaldo Queiroz");

// Utiliza o Facade para verificar condições de concessão ou não
bool resultado = concedeCreditoFacade.ConcederEmprestimo(cliente, 199000.00);

// Exibe o resultado 
Console.WriteLine($"O empréstimo pleiteado pelo cliente {cliente.Nome} foi {(resultado ? "Apovado": "Negado")}");

Console.ReadKey();