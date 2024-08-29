using Desafio.B3.Business.Interfaces;

namespace Desafio.B3.Business.Services
{
    public abstract class ImpostoService : IImpostoService
    {
        public double ObterCalcula(double valorMonetario, double valorBruto, double imposto)
        {
            var valoFinal = 0.0;

            valoFinal = valorBruto - ((valorBruto - valorMonetario) * (imposto / 100));

            return valoFinal;
        }

        public virtual double ObterImposto(int mes)
        {
            return 0.0; 
        }            
    }
}
