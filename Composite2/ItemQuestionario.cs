namespace Composite2
{
    //Component
    public abstract class ItemQuestionario
    {
        protected string Descricao;

        protected ItemQuestionario(string descricao)
        {
            Descricao = descricao;
        }

        public abstract void Exibir();
    }
}
