using Adapter1.Domain;

namespace Adapter1
{
    //Adaptee
    public class SistemaMensalidades
    {
        public void CalculaMensalidade(List<Aluno> alunos)
        {
            foreach (var aluno in alunos)
            {
                // Usa uma lógica para calcular a mensalidade
                var mensalidade =  aluno.Mensalidade * 1.1M;
                Console.WriteLine($"Aluno {aluno.Nome} - Valor da mensalidade R$ {mensalidade}");
            }
        }
    }
}
