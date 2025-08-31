/*
    >>> Ex1.:
    Suponha que você esta desenvolvendo um site que lida com fotos.

    Como um meio de indicar que as imagens são protegidas por direitos autorais, você deseja adicionar uma marca d'agua
    nas fotos quando são exibidas no navegador.

    No entanto, você deseja tornar esse recurso apcional;
    Assim os usuários poderão decidir se vão adicionar ou não uma marca d'agua em suas fotos.

    Então, a adição da marca d'agua ocorre em tempo de execução. Nesse caso, as fotos originais não terão nenhuma marca
    d'agua inicial.

    Com base nisso a sua aplicação vai precisar implementar a funcionalidade de incluir a marca d'agua nas fotos originais.

    >>> Ex1.: Solução
    Podemos resolver o problema apresentado usando o padrão DECORATOR
    Assim podemos definir a inclusão da marca d'agua na foto com uma
    funcionalidade extra que vamos adicionar em tempo de execução

    Este padrão permite adicionar uma funcionalidade extra a um objeto de forma dinâmica

    Este padrão aumenta a extensibilidade do objeto, porque as alterações sãp feitas através da codificação de
    novas classes (Princípio Aberto/Fechado)

 */
 

using Decorator4;

// Foto original (sem marca d’água)
IFoto fotoOriginal = new Foto("praia.jpg");
Console.WriteLine(fotoOriginal.Renderizar());

// Decisão em tempo de execução (usuário escolhe aplicar ou não)
bool aplicarMarca = true; // simule a escolha do usuário

IFoto fotoParaExibir = aplicarMarca
    ? new MarcaDagua(fotoOriginal, "© Enivaldo 2025")
    : fotoOriginal;

Console.WriteLine(fotoParaExibir.Renderizar());

// Observação: a foto original continua SEM marca d’água.
// O efeito é aplicado “na borda” (em tempo de execução), sem alterar o objeto base.