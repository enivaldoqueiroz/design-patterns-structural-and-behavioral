
namespace Abstracao1
{
    public class ServicoEmail
    {
        public void EnviarEmail() 
        {
            Conectar();
            Autenticar();
            Console.WriteLine("Enviando o email");
            Desconectar();
        }

        private void Desconectar()
        {
            Console.WriteLine("Desconectando o email");
        }

        private void Autenticar()
        {
            Console.WriteLine("Autenticando o email");
        }

        private void Conectar()
        {
            Console.WriteLine("Conectando o email");
        }
    }
}
