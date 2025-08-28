namespace Decoretor3
{
    // IVA (imposto) – ex.: 23%
    public class ComIVA : PrecificadorDecorator
    {
        private readonly decimal _aliquota;
        public ComIVA(IPrecificador precificador, decimal aliquotaPercent) : base(precificador)
        {
            _aliquota = aliquotaPercent / 100m ;
        }

        public override decimal Calcular()
        {
            return _precificador.Calcular() * (1 + _aliquota);
        }

        public override string Descricao()
        {
            return _precificador.Descricao() + $" | IVA: {_aliquota:P0}";
        }
    }
}
