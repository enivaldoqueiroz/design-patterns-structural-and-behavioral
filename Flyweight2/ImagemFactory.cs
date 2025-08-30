namespace Flyweight2
{
    //FlyweightFactory
    public class ImagemFactory
    {
        private static Dictionary<string, ImagemBase> imagens = new Dictionary<string, ImagemBase>();

        public ImagemBase GetImagem(string nomeArquivo)
        {
            ImagemBase imagem = null;
            if (imagens.ContainsKey(nomeArquivo))
            {
                imagem = imagens[nomeArquivo] as ImagemBase;
                Console.WriteLine($">>> Retornando imagem em cache : {nomeArquivo} >>>");
            }
            else
            {
                //criar uma nova imagem e incluir o cache
                imagem = new Imagem(nomeArquivo);
                imagens.Add(nomeArquivo, imagem);
                Console.WriteLine($"### Instanciando uma nova imagem : {nomeArquivo} ###");
            }

            return imagem;
        }
    }
}
