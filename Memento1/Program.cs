using Memento1;

Console.WriteLine("### Padrão Memento ###");
Console.WriteLine("Calcula a soma de dois numeros e armazena o estado ");
Console.WriteLine("Pressione algo para realizar outro calculo e rest");

// Cria instancia do tipo ICalculadora
ICalculadora calculadora = new Calculadora();

// Atribui dois numeros
calculadora.SetPrimeiroNumero(10);
calculadora.SetSegundoNumero(100);

// Retorna o resultado
Console.WriteLine($"### Estado 1: {calculadora.GetCalculoResultado()}");

// Armazena o resultado caso ocorra um erro
ICarataker memento = calculadora.BackupUltimoCalculo();
Console.ReadKey();

Console.WriteLine("\n Calcula uma nova soma de dois numeros \n");

// Atribui outro numero
calculadora.SetSegundoNumero(17);

// Atribui um segundo numero incorreto e calcula
calculadora.SetSegundoNumero(-290);

// Exibe o resultado
Console.WriteLine($"Estado 2 : {calculadora.GetCalculoResultado()}");

Console.WriteLine("\nRestaura o resultado da soma anterior\n");

// Realização da operação para desfazer a ultima operação (CTRL+Z, Undo)
calculadora.RestoreUltimoCalculo(memento);

// Realização o resultado do estado armazenado
Console.WriteLine($"### Estado 1 : {calculadora.GetCalculoResultado()}");

Console.ReadKey();