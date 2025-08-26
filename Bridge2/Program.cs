//📌 Cenário real

//Suponha que você tem um sistema que precisa desenhar formas geométricas (círculo, quadrado etc.) em diferentes modos de renderização (por exemplo: vetorial ou rasterizado).

//👉 Se você usar herança direta, teria que criar classes do tipo:

//CirculoRaster, CirculoVetorial,

//QuadradoRaster, QuadradoVetorial …

//Isso explode em combinações 🚨.
//Com o Bridge, separamos Abstração (Forma) de Implementação (Renderizador).

using Bridge2;

Forma circuloRaster = new Circulo(new RenderizadorRaster(), 10);
Forma circuloVetorial = new Circulo(new RenderizadorVetorial(), 15);

circuloRaster.Desenhar();
circuloVetorial.Desenhar();