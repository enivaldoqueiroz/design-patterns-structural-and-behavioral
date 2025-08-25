namespace Bridge1
{
    public abstract class Arquivo
    {
        protected IGerarArquivo _gerarArquivo;

        protected Arquivo(IGerarArquivo gerarArquivo)
        {
            _gerarArquivo = gerarArquivo;
        }
        public virtual void GravaAquivo(Funcionario funcionario)
        {
            _gerarArquivo.GeraAquivo(funcionario);
        }
    }
}
