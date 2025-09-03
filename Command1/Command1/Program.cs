using Command1;

Console.WriteLine("## Padrão Command ##");
//Cria uma instancia de Chef para poder preparar o pedido
//Receiver
Chef chef = new Chef();

//Prato
Pedido pedido = new Pedido(chef: chef, acao: "Prato");
Garcom garcom = new Garcom(pedido: pedido);
garcom.Excutar();

//Sobremesa
pedido = new Pedido(chef: chef, acao: "Sobremesa");
garcom = new Garcom(pedido: pedido);
garcom.Excutar();

Console.ReadKey();