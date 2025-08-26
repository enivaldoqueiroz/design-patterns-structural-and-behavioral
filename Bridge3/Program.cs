//📌 Cenário: Controle remoto de aparelhos

//Imagine que temos aparelhos diferentes (TV, Rádio, etc.) e controles diferentes (básico, avançado).

//Sem o Bridge → você teria que criar classes do tipo ControleBasicoTV, ControleBasicoRadio, ControleAvancadoTV, ControleAvancadoRadio… 🚨 explosão de combinações.

//Com o Bridge → separamos Abstração (Controle) de Implementação (Dispositivo).

using Bridge3;

ControleRemoto controleTV = new ControleAvancado(new TV());
ControleRemoto controleRadio = new ControleAvancado(new Radio());

// Usando controle da TV
controleTV.Ligar();
controleTV.Volume(20);

// Usando controle do Rádio
controleRadio.Ligar();
controleRadio.Volume(10);

// Função extra do controle avançado
var controleAvancadoTV = new ControleAvancado(new TV());
controleAvancadoTV.Ligar();
controleAvancadoTV.Mudo();