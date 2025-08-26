namespace Decorator1
{
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {  }

        public override string Opcionais()
        {
            var opcionais = base.Opcionais();
            opcionais += "\r\n com porção extra de bacon";
            return opcionais;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 4.00M;
            return preco;
        }
    }
}
