using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade1.Subsistemas
{
    public class LimiteCredito
    {
        public bool PossuiLimiteCredito(Cliente cliente, double valor)
        {
            Console.WriteLine($"Verificando o limite de crédito do cliente {cliente.Nome}");
            
            if(valor > 200000.00)
                return false;
            else
                return true;
        }
    }
}
