namespace Bridge3
{
    // Abstração
    public abstract class ControleRemoto
    {
        protected IDispositivo dispositivo;

        protected ControleRemoto(IDispositivo d)
        {
            dispositivo = d;
        }

        public virtual void Ligar() => dispositivo.Ligar();
        public virtual void Desligar() => dispositivo.Desligar();
        public virtual void Volume(int valor) => dispositivo.AjustarVolume(valor);
    }
}
