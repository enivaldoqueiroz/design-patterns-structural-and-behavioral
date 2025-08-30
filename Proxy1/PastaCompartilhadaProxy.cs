namespace Proxy1
{
    //Proxy - Contém uma referencia a classe RealSubject e poder acessar os membros da classe RealSubject conforme necessário
    public class PastaCompartilhadaProxy : IPastaCompartilhada
    {
        private IPastaCompartilhada _pastaCompartilhada;
        private Funcionario _funcionario;

        public PastaCompartilhadaProxy(Funcionario funcionario)
        {
            _funcionario = funcionario;
        }

        public void OperacaoDeLeituraGravacao()
        {
            if (_funcionario.Perfil.ToUpper() == "CEO")
            {
                Console.WriteLine("O proxy 'Pasta Compartilhada' invoca a pasta Real : método usado : OperacaoDeLeituraGravacao()'\n");
                _pastaCompartilhada = new PastaCompartilhada();
                _pastaCompartilhada.OperacaoDeLeituraGravacao();
            }
            else 
                Console.WriteLine("O proxy 'Pasta Compartilhada' avisa : 'Você não tem permissão para acessar esta pasta'\n");
        }
    }
}
