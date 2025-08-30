//📌 Cenário: Loja Online

//Um cliente quer comprar um produto.
//Por baixo dos panos, temos vários subsistemas:

//Estoque → verificar disponibilidade.

//Pagamento → processar cartão.

//Entrega → agendar envio.

//👉 O cliente não precisa lidar com cada subsistema. Criamos uma Facade (LojaFacade) que simplifica tudo.

using Facade3;

var loja = new LojaFacade();

// Cliente usa apenas UMA chamada
loja.ComprarProduto(
    produto: "Notebook",
    cartao: "1234-****-****-5678",
    valor: 3500.00m,
    endereco: "Rua das Flores, 123"
);