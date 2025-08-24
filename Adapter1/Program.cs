using Adapter1;

var alunosArray = SistemaEscolar.GetListaAlunosMensalidade();

ICalculaMensalidade calculaMensalidade = new AlunoAdapter();
calculaMensalidade.ProcessCalculaMensalidade(alunosArray);

Console.ReadLine();