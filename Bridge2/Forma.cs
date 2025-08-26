using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    // Abstração (Bridge conecta aqui)
    public abstract class Forma
    {
        protected IRenderizador renderizador;

        protected Forma(IRenderizador r)
        {
            renderizador = r;
        }

        public abstract void Desenhar();
    }
}
