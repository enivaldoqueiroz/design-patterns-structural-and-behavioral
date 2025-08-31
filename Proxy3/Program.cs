// 📌 Cenário: Acesso a Imagens Pesadas
//
// Imagine que você tem imagens grandes que demoram para carregar.
//
// Sem proxy → sempre carregamos a imagem completa, mesmo que ela não seja usada.
//
// Com proxy → usamos um objeto substituto que só carrega a imagem real quando necessário (lazy loading).

using Proxy3;

IImagem img1 = new ImagemProxy("foto1.png");
IImagem img2 = new ImagemProxy("foto2.png");

// Até aqui nada foi carregado do disco
Console.WriteLine("Imagens criadas, mas não carregadas ainda...\n");

// A imagem só será carregada quando for exibida
img1.Exibir();
Console.WriteLine();

// A segunda também só carrega ao ser exibida
img2.Exibir();
Console.WriteLine();

// Exibir novamente NÃO recarrega do disco
img1.Exibir();