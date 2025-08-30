namespace Facade3
{
    // Subsistema 1: Estoque
    public class Estoque
    {
        public bool VerificarDisponibilidade(string produto)
        {
            Console.WriteLine($"Verificando estoque para {produto}...");
            return true; // simplificação
        }
    }
}
