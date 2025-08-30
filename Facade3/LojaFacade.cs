namespace Facade3
{
    // Facade
    public class LojaFacade
    {
        private readonly Estoque _estoque = new();
        private readonly Pagamento _pagamento = new();
        private readonly Entrega _entrega = new();

        public void ComprarProduto(string produto, string cartao, decimal valor, string endereco)
        {
            if (!_estoque.VerificarDisponibilidade(produto))
            {
                Console.WriteLine("Produto indisponível!");
                return;
            }

            if (!_pagamento.ProcessarCartao(cartao, valor))
            {
                Console.WriteLine("Falha no pagamento!");
                return;
            }

            _entrega.Agendar(produto, endereco);
            Console.WriteLine("Compra concluída com sucesso!");
        }
    }
}
