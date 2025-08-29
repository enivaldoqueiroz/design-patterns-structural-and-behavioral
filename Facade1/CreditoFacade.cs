using Facade1.Subsistemas;

namespace Facade1
{
    public class CreditoFacade
    {
        private LimiteCredito limiteCredito;
        private Serasa serasa;
        private Cadin cadin;
        private Cadastro cadastro;

        public CreditoFacade()
        {
            limiteCredito = new LimiteCredito();
            serasa = new Serasa();
            cadin = new Cadin();
            cadastro = new Cadastro();
        }

        public bool ConcederEmprestimo(Cliente cliente, double valor)
        {
            Console.WriteLine($"{cliente.Nome} este pleitando um emprestimo no valor de {valor:C}\n");

            // cadastro
            cadastro.CadastrarCliente(cliente);

            bool concederEmprestimo = true;
            if(serasa.EstaNoSerasa(cliente))
            {
                // Verifica o Serasa
                Console.WriteLine($"Cliente {cliente.Nome} possui restrição no SERASA");
                concederEmprestimo = false;
            }

            if(cadin.EstaNoCadin(cliente))
            {
                // Verifica o Cadin
                Console.WriteLine($"Cliente {cliente.Nome} possui restrição no CADIN");
                concederEmprestimo = false;
            }

            if(!limiteCredito.PossuiLimiteCredito(cliente, valor))
            {
                // Verifica se o Cliente tem limite de crédito para o valor requerido
                Console.WriteLine($"O Cliente {cliente.Nome} possui limite de crédito inferior a {valor:C}\n");
                concederEmprestimo = false;
            }

            //true => Conceder | false => Negar
            return concederEmprestimo;
        }
    }
}
