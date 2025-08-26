namespace Composite2
{
    //Composite
    public class Grupo : ItemQuestionario
    {
        private IList<ItemQuestionario> _items = new List<ItemQuestionario>();

        public Grupo(string descricao) : base(descricao)
        {
        }

        public override void Exibir()
        {
            Console.WriteLine($"Grupo : {Descricao}");
            foreach ( var item in _items)
            {
                item.Exibir();
            }
        }

        public void Add(ItemQuestionario itemQuestionario)
        {
            _items.Add(itemQuestionario);
        }

        public void Remove(ItemQuestionario itemQuestionario)
        {
            _items.Remove(itemQuestionario);
        }
    }
}
