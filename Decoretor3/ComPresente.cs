namespace Decoretor3
{
    // Embalagem de presente – taxa fixa
    public class ComPresente : PrecificadorDecorator
    {
        private readonly decimal _taxa;
        public ComPresente(IPrecificador precificador, decimal taxa) : base(precificador)
        {
            _taxa = taxa;
        }

        public override decimal Calcular()
        {
            return _precificador.Calcular() + _taxa;
        }

        public override string Descricao()
        {
            return _precificador.Descricao() + $" | Presente:{_taxa:C}";
        }
    }
}
