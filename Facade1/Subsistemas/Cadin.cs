namespace Facade1.Subsistemas
{
    public class Cadin
    {
        public bool EstaNoCadin(Cliente cliente)
        {
            Console.WriteLine("Verificando CADIN do Cliente " + cliente.Nome);
            return false;
        }
    }
}
