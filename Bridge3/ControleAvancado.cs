using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge3
{
    // Abstração refinada (Concrete Abstraction)
    public class ControleAvancado : ControleRemoto
    {
        public ControleAvancado(IDispositivo d) : base(d) { }

        public void Mudo()
        {
            Console.WriteLine("Ativando modo MUDO...");
            dispositivo.AjustarVolume(0);
        }
    }
}
