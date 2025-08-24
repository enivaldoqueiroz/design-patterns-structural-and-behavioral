class Cliente 
{
    // atributos
    public string Nome { get; set; }
    
    // métodos
    public Cliente(string nome) 
    {
        Nome = nome;
    }

    public void Saudacao() 
    {
        Console.WriteLine($"Olá, meu nome é : " + Nome);
    }
}