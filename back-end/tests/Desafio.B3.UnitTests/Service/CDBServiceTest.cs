using Desafio.B3.Business.Interfaces;
using FluentAssertions;
using Desafio.B3.Business.Domain;
using Desafio.B3.Business.Services;

namespace Desafio.B3.UnitTests.Service
{
    public class CDBServiceTest
    {
        [Theory(DisplayName = nameof(CalcularCDBLiquido))]
        [Trait("Service", "CDB - Service")]
        [InlineData(100.0, 2, 101.95344784)]
        [InlineData(100.0, 3, 102.94443535300479)]
        [InlineData(100.0, 5, 104.95540120180826)]
        public void CalcularCDBLiquido(double cdbMonetario, int cdbMes, double resultado)
        {
            ICdbService cdb = new CdbService();

            var valorFinal = cdb.ObterCalculo(new Cdb(cdbMonetario, cdbMes));

            valorFinal.Should().NotBe(null);
            valorFinal.Should().Be(resultado);
        }
    }
}
