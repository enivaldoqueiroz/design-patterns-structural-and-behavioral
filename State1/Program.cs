using State1;

// Caixa Eletronico: Estado inicial CartaoNaoInseridoState
CaixaEletronico caixaEletronico = new CaixaEletronico();
Console.WriteLine($"Estado atual do Caixa Eletronico : " +
                  $"{caixaEletronico.caixaEletronicoState.GetType().Name}");
Console.WriteLine();
caixaEletronico.InformarSenha();
caixaEletronico.SacarDinheiro();
caixaEletronico.EjetarCartao();
caixaEletronico.InserirCartao();
Console.WriteLine();

// Cartao foi inserido o estado interno modou para CartaoInseridoState
Console.WriteLine($"Estado atual do Caixa Eletronico : " +
                  $"{caixaEletronico.caixaEletronicoState.GetType().Name}");
Console.WriteLine();
caixaEletronico.InformarSenha();
caixaEletronico.SacarDinheiro();
caixaEletronico.InserirCartao();
caixaEletronico.EjetarCartao();
Console.WriteLine("");

// Cartao foi ejectado, estado interno mudou para CartaoNaoIseridoState
Console.WriteLine($"Estado atual do Caixa Eletronico : " +
                  $"{caixaEletronico.caixaEletronicoState.GetType().Name}");
Console.Read();
                  