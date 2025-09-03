namespace Interpreter1
{
    public class Context
    {
        public DateTime Data { get; set; }
        public string Expressao { get; set; }
        public Context(DateTime data)
        {
            Data = data;
        }
    }
}
