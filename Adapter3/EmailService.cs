namespace Adapter3
{
    // Biblioteca externa (não podemos modificar)
    public class EmailService
    {
        public void SendEmail(string assunto, string conteudo)
        {
            Console.WriteLine($"[EMAIL] Assunto: {assunto} | Conteúdo: {conteudo}");
        }
    }
}
