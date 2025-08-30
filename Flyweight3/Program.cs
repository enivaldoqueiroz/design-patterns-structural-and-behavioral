//📌 Cenário: Editor de Texto

//Imagine que você está criando um editor de texto.

//Cada caractere tem um estado intrínseco (imutável e compartilhável, como a fonte, tamanho e estilo).

//Mas cada ocorrência tem um estado extrínseco (posição no documento, cor do destaque etc.), que não precisa ser compartilhado.

//👉 Sem Flyweight → cada letra repetida (ex.: 1 milhão de "a") teria um objeto completo duplicado na memória.
//👉 Com Flyweight → só existe 1 objeto para o "a", e o resto da informação é passado como parâmetro quando usado.

using Flyweight3;

var factory = new FlyweightFactory();

// Reutiliza o mesmo objeto para 'a' na mesma fonte/tamanho
var a1 = factory.GetCaractere('a', "Arial", 12);
a1.Desenhar(0, 0, "Preto");

var a2 = factory.GetCaractere('a', "Arial", 12);
a2.Desenhar(1, 0, "Azul");

// Diferente porque muda a fonte
var a3 = factory.GetCaractere('a', "Times New Roman", 12);
a3.Desenhar(2, 0, "Vermelho");

// Outro caractere
var b = factory.GetCaractere('b', "Arial", 12);
b.Desenhar(3, 0, "Preto");