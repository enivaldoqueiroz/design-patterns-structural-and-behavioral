namespace Bridge2
{
    // Abstração refinada (Concrete Abstraction)
    public class Circulo : Forma
    {
        private readonly int _raio;

        public Circulo(IRenderizador r, int raio) : base(r)
        {
            _raio = raio;
        }

        public override void Desenhar()
        {
            renderizador.DesenharCirculo(_raio);
        }
    }
}
