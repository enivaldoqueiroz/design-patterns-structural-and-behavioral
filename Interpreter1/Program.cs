using Interpreter1;

List<IAbstractExpression> expressions = new List<IAbstractExpression>();

Context context = new Context(DateTime.Now);
Console.WriteLine($"Data atual : {context.Data}\n");

Console.WriteLine("Selecione a expressão a usar : MM-DD-YYYY ou YYYY-MM-DD ou DD-MM-YYYY ");

context.Expressao = Console.ReadLine().ToUpper();

string[] formato = context.Expressao.Split('-');

foreach (string item in formato)
{
    switch (item)
    {
        case "DD":
            expressions.Add(new ExpressaoDia()); break;
        case "MM":
            expressions.Add(new ExpressaoMes()); break;
        case "YYYY":
            expressions.Add(new ExpressaoAno()); break;
        default:
            throw new Exception("Expressão invalida!");
    }
}

expressions.Add(new Separador());

foreach (var obj in expressions)
{
    obj.Avaliar(context);
}

Console.WriteLine($"\nData na expressão escolhida : {context.Expressao}");
Console.ReadLine();