namespace Decorator3
{
    // Cupom de desconto – percentual
    public class ComCupom : PrecificadorDecorator
    {
        private readonly decimal _percent;
        public ComCupom(IPrecificador inner, decimal percent) : base(inner) => _percent = percent / 100m;

        public override decimal Calcular()
        {
            return _precificador.Calcular() * (1 - _percent);
        }

        public override string Descricao()
        {
            return _precificador.Descricao() + $" | Cumpom:{_percent:P0} off";
        }
    }
}
