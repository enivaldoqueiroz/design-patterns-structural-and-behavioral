

using TemplateMethod1;

Console.WriteLine("------- Video Player - Video MP4  ------- ");
Console.WriteLine("Exemplo de Implementação");
Console.ReadLine();

Console.WriteLine("------- Video Player - Video MP4  ------- ");
VideoPlayer arquivoVideo = new VideoMP4();
arquivoVideo.CarregarArquivo();
arquivoVideo.DecodeVideoFormato();
arquivoVideo.InciarExecucao();

Console.WriteLine("------- Video Player - Video MKV  ------- ");
arquivoVideo = new VideoMKV();
arquivoVideo.CarregarArquivo();
arquivoVideo.DecodeVideoFormato();
arquivoVideo.InciarExecucao();

Console.ReadLine();