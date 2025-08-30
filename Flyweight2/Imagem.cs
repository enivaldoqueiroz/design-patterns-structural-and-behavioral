namespace Flyweight2
{
    public class Imagem : ImagemBase
    {
        //estado intrinseco - compartilhável
        protected string _nomeArquivo;

        public Imagem(string nomeArquivo)
        {
            _nomeArquivo = nomeArquivo;
        }

        //estado extrinseco - não compartilhável


        public override void Exibir(int x, int y, int largura, int altura)
        {
            Console.WriteLine($"<img src={_nomeArquivo} style=left:{x}px; top:{y}px; width:{largura}px; heigth:{altura}px/>");
        }
    }
}
