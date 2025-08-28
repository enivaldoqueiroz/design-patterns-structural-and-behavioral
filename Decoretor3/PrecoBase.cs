namespace Decoretor3
{
    // Concreto (preço base do pedido)
    public class PrecoBase : IPrecificador
    {
        private readonly decimal _subtotal;
        public PrecoBase(decimal subtotal)
        {
            _subtotal = subtotal;
        }

        public decimal Calcular()
        {
            return _subtotal;
        }

        public string Descricao()
        {
            return $"Subtotal: {_subtotal}";
        }
    }
}
