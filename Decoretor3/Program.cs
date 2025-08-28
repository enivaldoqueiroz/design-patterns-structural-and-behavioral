// O contexto do Decorator para um caso de preço de pedido (e-commerce): aplicar impostos, frete, desconto de cupom e embalagem de presente de forma combinável.
//📌 Ideia

//Componente(IPrecificador) → calcula preço final.

//Concreto (PrecoBase) → preço do carrinho.

//Decorators → ComIVA, ComFrete, ComCupom, ComPresente adicionam regras sem criar mil subclasses.

using Decoretor3;
using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("pt-PT");         // € formatação

IPrecificador pedido = new PrecoBase(100.00m);                 // subtotal €100
pedido = new ComIVA(pedido, 23);                               // +23% IVA
pedido = new ComFrete(pedido, 4.99m);                          // +€4,99 frete
pedido = new ComCupom(pedido, 10);                             // -10% cupom
pedido = new ComPresente(pedido, 2.50m);                       // +€2,50 embalagem

Console.WriteLine(pedido.Descricao());
Console.WriteLine($"Total: {pedido.Calcular():C}");