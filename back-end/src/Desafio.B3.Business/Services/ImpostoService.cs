using Desafio.B3.Business.Interfaces;
using Desafio.B3.Business.Services.TabelaImposto;

namespace Desafio.B3.Business.Services
{
    public abstract class ImpostoService : IImpostoService
    {
        public double ObterCalculo(double valorMonetario, double valorBruto, double imposto)
        {
            var valoFinal = 0.0;

            valoFinal = valorBruto - ((valorBruto - valorMonetario) * (imposto / 100));

            return valoFinal;
        }

        public virtual double ObterImposto(int mes)
        {
            return new ImpostoAte6MesesService().ObterImposto(mes); 
        }            
    }
}
