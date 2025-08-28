namespace Decoretor3
{
    // Decorator base
    public abstract class PrecificadorDecorator : IPrecificador
    {
        protected readonly IPrecificador _precificador;

        protected PrecificadorDecorator(IPrecificador precificador)
        {
            _precificador = precificador;
        }

        public abstract decimal Calcular();

        public abstract string Descricao();
    }
}
