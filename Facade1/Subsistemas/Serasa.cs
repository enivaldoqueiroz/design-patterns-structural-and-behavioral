namespace Facade1.Subsistemas
{
    public class Serasa
    {
        public bool EstaNoSerasa(Cliente cliente)
        {
            Console.WriteLine("Verificando SERASA do Cliente " + cliente.Nome);
            return false;
        }
    }
}
