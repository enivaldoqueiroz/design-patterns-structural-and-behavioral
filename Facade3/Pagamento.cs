namespace Facade3
{
    // Subsistema 2: Pagamento
    public class Pagamento
    {
        public bool ProcessarCartao(string numero, decimal valor)
        {
            Console.WriteLine($"Processando pagamento de {valor:C} no cartão {numero}...");
            return true; // simplificação
        }
    }
}
