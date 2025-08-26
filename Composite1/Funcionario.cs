namespace Composite1
{
    public class Funcionario : HoraTrabalhada
    {
        public int Horas { get; set; }

        public override int GetHoraTrabalhada()
        {
            //Logica
            Console.WriteLine($"O funcionário {Nome} registou {Horas} Trabalhadas");

            return Horas;
        }
    }
}
