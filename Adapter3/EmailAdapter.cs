namespace Adapter3
{
    // Adapter que traduz de INotificacao para EmailService
    public class EmailAdapter : INotificacao
    {
        private readonly EmailService _emailService;

        public EmailAdapter(EmailService emailService)
        {
            _emailService = emailService;
        }

        public void Enviar(string mensagem)
        {
            // Aqui fazemos a adaptação da interface
            _emailService.SendEmail("Notificação do Sistema", mensagem);
        }
    }
}
