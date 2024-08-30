using Desafio.B3.Business.Domain;
using Desafio.B3.Business.Interfaces;

namespace Desafio.B3.Business.Services
{
    public class CdbService : ICdbService
    {
        public double ObterCalculo(Cdb cdb)
        {
            var taxas = new Taxas();
            var valorFinal = cdb.ValorMonetario;

            for (int i = 0; i < cdb.Mes; i++)
            {                
                valorFinal *= ( 1 + ( (taxas.CDI / 100) * (taxas.TB / 100) ) );
            }
            
            return valorFinal;
        }
    }
}
