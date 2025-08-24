
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
            throw new NotImplementedException();
        }

        private void Autenticar()
        {
            throw new NotImplementedException();
        }

        private void Conectar()
        {
            throw new NotImplementedException();
        }
    }
}
