namespace Decorator2
{
    public abstract class OptionalDecorator : ICafe
    {
        protected ICafe _cafe;
        protected string _optional = "indefinido";
        protected decimal _preco = 0.00M;

        protected OptionalDecorator(ICafe cafe)
        {
            _cafe = cafe;
        }

        public string Descricao()
        {
            return _cafe.Descricao() + _optional;
        }

        public decimal Preco()
        {
            return _cafe.Preco() + _preco;
        }
    }
}
