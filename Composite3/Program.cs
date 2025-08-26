//📌 Cenário: Estrutura de arquivos e pastas

//Folha (Leaf) → Arquivo

//Composto (Composite) → Pasta (pode conter arquivos e/ou outras pastas)

//Cliente → Trabalha com INodo sem se preocupar se é arquivo ou pasta.

// Criando arquivos
using Composite3;

var arq1 = new Arquivo("arquivo1.txt");
var arq2 = new Arquivo("arquivo2.txt");
var arq3 = new Arquivo("foto.png");

// Criando pastas
var pastaDocs = new Pasta("Documentos");
var pastaImgs = new Pasta("Imagens");
var pastaRaiz = new Pasta("Raiz");

// Montando a árvore
pastaDocs.Adicionar(arq1);
pastaDocs.Adicionar(arq2);

pastaImgs.Adicionar(arq3);

pastaRaiz.Adicionar(pastaDocs);
pastaRaiz.Adicionar(pastaImgs);

// Cliente trata tudo como INodo
pastaRaiz.Exibir();