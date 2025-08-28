namespace Decoretor3
{
    // Frete – valor fixo
    public class ComFrete : PrecificadorDecorator
    {
        private readonly decimal _valorFrete;

        public ComFrete(IPrecificador precificador, decimal valorFrete) : base(precificador)
        {
            _valorFrete = valorFrete;
        }

        public override decimal Calcular()
        {
            return _precificador.Calcular() + _valorFrete;
        }

        public override string Descricao()
        {
            return _precificador.Descricao() + $" | Frete: {_valorFrete:C}";
        }
    }
}
