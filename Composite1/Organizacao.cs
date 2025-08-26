namespace Composite1
{
    // Composite
    public class Organizacao : HoraTrabalhada
    {
        protected List<HoraTrabalhada> departamentos = new List<HoraTrabalhada>();

        public override void Add(HoraTrabalhada component)
        {
            departamentos.Add(component);
        }

        public override int GetHoraTrabalhada()
        {
            var horasTrabalhadasDepartamento = 0;
            foreach (var departamento in departamentos)
            {
                horasTrabalhadasDepartamento += departamento.GetHoraTrabalhada();
            }

            Console.WriteLine($"{Nome} registou um total de {horasTrabalhadasDepartamento} \n");

            return horasTrabalhadasDepartamento;
        }
    }
}
