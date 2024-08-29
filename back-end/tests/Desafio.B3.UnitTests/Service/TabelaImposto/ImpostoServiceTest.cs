using Desafio.B3.Business.Interfaces;
using Desafio.B3.Business.Services.TabelaImposto;
using FluentAssertions;

namespace Desafio.B3.UnitTests.Service.TabelaImposto
{
    public class ImpostoServiceTest
    {
        [Theory(DisplayName = nameof(ValorDoImpostoAte6Meses))]
        [Trait("Service", "Imposto - Service")]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(6)]
        public void ValorDoImpostoAte6Meses(int mes)
        {
            IImpostoService imposto = new ImpostoAte6MesesService();

            var valor = imposto.ObterImposto(mes);

            valor.Should().NotBe(null);
            valor.Should().Be(22.5);
        }

        [Theory(DisplayName = nameof(ValorDoImpostoDe7Ate12Meses))]
        [Trait("Service", "Imposto - Service")]
        [InlineData(7)]
        [InlineData(9)]
        [InlineData(12)]
        public void ValorDoImpostoDe7Ate12Meses(int mes)
        {
            IImpostoService imposto = new ImpostoDe7Ate12MesesService();

            var valor = imposto.ObterImposto(mes);

            valor.Should().NotBe(null);
            valor.Should().Be(20.0);
        }

        [Theory(DisplayName = nameof(ValorDoImpostoDe13Ate24Meses))]
        [Trait("Service", "Imposto - Service")]
        [InlineData(13)]
        [InlineData(15)]
        [InlineData(24)]
        public void ValorDoImpostoDe13Ate24Meses(int mes)
        {
            IImpostoService imposto = new ImpostoDe13Ate24MesesService();

            var valor = imposto.ObterImposto(mes);

            valor.Should().NotBe(null);
            valor.Should().Be(17.5);
        }

        [Theory(DisplayName = nameof(ValorDoImpostoAcimaDe24Meses))]
        [Trait("Service", "Imposto - Service")]
        [InlineData(25)]
        [InlineData(30)]
        [InlineData(80)]
        public void ValorDoImpostoAcimaDe24Meses(int mes)
        {
            IImpostoService imposto = new ImpostoAcimaDe24MesesService();

            var valor = imposto.ObterImposto(mes);

            valor.Should().NotBe(null);
            valor.Should().Be(15.0);
        }

        [Theory(DisplayName = nameof(ValorInvestimentoLiquido))]
        [Trait("Service", "Imposto - Service")]
        [InlineData(100.0, 2, 101.95344784, 101.513922076)]
        [InlineData(100.0, 3, 102.94443535300479, 102.28193739857872)]
        [InlineData(100.0, 5, 104.95540120180826, 103.8404359314014)]
        public void ValorInvestimentoLiquido(double valorMonetario, int mes, double valorBruto, double resultado)
        {
            IImpostoService imposto = new ImpostoAte6MesesService();            

            var valorImposto = imposto.ObterImposto(mes);
            var valorLiquido = imposto.ObterCalcula(valorMonetario, valorBruto, valorImposto);

            valorLiquido.Should().NotBe(null);
            valorLiquido.Should().Be(resultado);
        }
    }
}
