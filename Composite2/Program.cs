using Composite2;

var GrupoA = new Grupo("A) Português");
var questao1 = new Questao("Quando usamos a crase?");
var questao2 = new Questao("Qual o sinônimo de rápido?");

GrupoA.Add(questao1);
GrupoA.Add(questao2);

var GrupoB = new Grupo("B) Física");
var GrupoB1 = new Grupo("B1) Mêcanica");
var questao3 = new Questao("O que é velocidade média?");
var questao4 = new Questao("O que é aceleração?");

GrupoB1.Add(questao3);
GrupoB1.Add(questao4);

var GrupoB2 = new Grupo("B2) Óptica");
var questao5 = new Questao("O que é refração?");
var questao6 = new Questao("O que é a velocidade da luz?");

GrupoB2.Add(questao5);
GrupoB2.Add(questao6);

GrupoB.Add(GrupoB1);
GrupoB.Add(GrupoB2);

//Matemática
var GrupoC = new Grupo("C) Matem[atica");
var questao7 = new Questao("Qual a raiz quadrada de 126?");
var questao8 = new Questao("Qual a valor do número de PI?");

GrupoC.Add(questao7);
GrupoC.Add(questao8);

var GrupoRaiz = new Grupo("Questionario");
GrupoRaiz.Add(GrupoA);
GrupoRaiz.Add(GrupoB);
GrupoRaiz.Add(GrupoC);

//Exibir
GrupoRaiz.Exibir();

Console.ReadLine();
