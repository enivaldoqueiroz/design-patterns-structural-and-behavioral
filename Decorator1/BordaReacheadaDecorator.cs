namespace Decorator1
{
    public class BordaReacheadaDecorator : PizzaDecorator
    {
        public BordaReacheadaDecorator(IPizza pizza) : base(pizza)
        {  }

        public override string Opcionais()
        {
            var opcionais = base.Opcionais();
            opcionais += "\r\n com com borda recheada";
            return opcionais;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 3.00M;
            return preco;
        }
    }
}
