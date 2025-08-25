namespace Adapter3
{
    // Cliente que depende de INotificacao
    public class Sistema
    {
        private readonly INotificacao _notificacao;

        public Sistema(INotificacao notificacao)
        {
            _notificacao = notificacao;
        }

        public void Processar()
        {
            Console.WriteLine("Processando dados...");
            _notificacao.Enviar("Processo concluído com sucesso!");
        }
    }
}
