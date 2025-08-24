using Adapter1.Domain;

namespace Adapter1
{
    public class AlunoAdapter : ICalculaMensalidade
    {
        private SistemaMensalidades SistemaMensalidades = new SistemaMensalidades();
        public void ProcessCalculaMensalidade(string[,] alunosArray)
        {
            string Id = null;
            string Nome = null;
            string Mensalidade = null;

            List<Aluno> listaAlunos = new List<Aluno>();

            CoverteArrayParaList(alunosArray, Id, Nome, Mensalidade, listaAlunos);

            SistemaMensalidades.CalculaMensalidade(listaAlunos);
        }

        private void CoverteArrayParaList(string[,] alunosArray, string? id, string? nome, string? mensalidade, List<Aluno> listaAlunos)
        {
            for (int i = 0; i < alunosArray.GetLength(0); i++)
            {
                for (int j = 0; j < alunosArray.GetLength(1); j++)
                {
                    if (j == 0)
                        id = alunosArray[i, j];
                    else if (j == 1)
                        nome = alunosArray[i, j];
                    else
                        mensalidade = alunosArray[i, j];
                }
                //cria a lista de objetos aluno
                listaAlunos.Add(new Aluno(Convert.ToInt32(id), nome, Convert.ToDecimal(mensalidade)));
            }
        }
    }
}
