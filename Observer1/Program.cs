using Observer1;

// Criar um produto sem estaque e exibe disponibilidade
ConcreteSubject IPhone11 = new ConcreteSubject("Phone 11", 4900, "Sem Estoque");
Console.WriteLine($"Phone 11 - estado atual : {IPhone11.GetDisponibilidade()}");

Console.WriteLine("\n Observers inscritos para receber notificações sobre o produto IPhone 11\n");

// Criar Usuario Enivaldo e registrar objeto no Subject
ConcreteObserver enivaldo = new ConcreteObserver("Enivaldo", IPhone11);
// Criar Usuario Lana e registrar objeto no Subject
ConcreteObserver lana = new ConcreteObserver("Lana", IPhone11);
// Criar Usuario Mila e registrar objeto no Subject
ConcreteObserver mila = new ConcreteObserver("Mila", IPhone11);

Console.WriteLine("\n Pressione algo para alterar a disponibilidade e notificar os observers\n");
Console.ReadKey();

// Alterar Status do Subject e notifica observers
IPhone11.SetDisponibilidade("Disponível");

Console.Read();
