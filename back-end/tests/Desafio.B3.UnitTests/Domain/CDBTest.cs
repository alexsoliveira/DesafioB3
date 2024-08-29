using Desafio.B3.Business.Domain;
using Desafio.B3.Business.Exceptions;
using FluentAssertions;

namespace Desafio.B3.UnitTests.Domain
{
    [Collection(nameof(CDBTestFixture))]
    public class CDBTest
    {
        private readonly CDBTestFixture _fixture;

        public CDBTest(CDBTestFixture fixture)
            => _fixture = fixture;

        [Fact(DisplayName = nameof(InstanciaCDB))]
        [Trait("Domain", "CDB - Aggregates")]
        public void InstanciaCDB()
        {
            var cdbValido = _fixture.ObterCDBValido();

            var cdb = new CDB(cdbValido.ValorMonetario, cdbValido.Mes);

            cdb.Should().NotBeNull();
            cdb.ValorMonetario.Should().Be(cdbValido.ValorMonetario);
            cdb.Mes.Should().Be(cdbValido.Mes);
        }

        [Fact(DisplayName = nameof(InstanciaCDBValorMonetarioPositivos))]
        [Trait("Domain", "CDB - Aggregates")]
        public void InstanciaCDBValorMonetarioPositivos()
        {
            var cdbValido = _fixture.ObterCDBValido();
            var valorMonetario = _fixture.ObterValorMonetarioValido();

            var cdb = new CDB(valorMonetario, cdbValido.Mes);

            cdb.Should().NotBeNull();
            cdb.ValorMonetario.Should().Be(valorMonetario);
            cdb.Mes.Should().Be(cdbValido.Mes);
        }

        [Fact(DisplayName = nameof(InstanciaCDBMesMaiorQueUm))]
        [Trait("Domain", "CDB - Aggregates")]
        public void InstanciaCDBMesMaiorQueUm()
        {
            var cdbValido = _fixture.ObterCDBValido();
            var mes = _fixture.ObterMesValido();

            var cdb = new CDB(cdbValido.ValorMonetario, mes);

            cdb.Should().NotBeNull();
            cdb.ValorMonetario.Should().Be(cdbValido.ValorMonetario);
            cdb.Mes.Should().Be(mes);
        }

        [Theory(DisplayName = nameof(ValidarValorMonetarioPositivos))]
        [Trait("Domain", "CDB - Aggregates")]
        [InlineData(0.0)]
        [InlineData(100.0)]
        [InlineData(11110.0)]
        public void ValidarValorMonetarioPositivos(double valorMonetario)
        {
            var cdbValido = _fixture.ObterCDBValido();

            var cdb = new CDB(valorMonetario, cdbValido.Mes);

            cdb.Should().NotBeNull();
            cdb.ValorMonetario.Should().Be(valorMonetario);
            cdb.Mes.Should().Be(cdbValido.Mes);
        }

        [Theory(DisplayName = nameof(ValidarMesMaiorQueUm))]
        [Trait("Domain", "CDB - Aggregates")]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(8)]
        public void ValidarMesMaiorQueUm(int mes)
        {
            var cdbValido = _fixture.ObterCDBValido();            

            var cdb = new CDB(cdbValido.ValorMonetario, mes);

            cdb.Should().NotBeNull();
            cdb.ValorMonetario.Should().Be(cdbValido.ValorMonetario);
            cdb.Mes.Should().Be(mes);
        }

        [Theory(DisplayName = nameof(ValidarErrorQuandoValorMonetarioNegativos))]
        [Trait("Domain", "CDB - Aggregates")]
        [InlineData(-1.0)]
        [InlineData(-100.0)]
        [InlineData(-11110.0)]
        public void ValidarErrorQuandoValorMonetarioNegativos(double valorMonetario)
        {
            var cdbValido = _fixture.ObterCDBValido();

            Action action = () => new CDB(valorMonetario, cdbValido.Mes);

            action.Should()
                .Throw<EntityValidationException>()
                .WithMessage("O campo ValorMonetario, só aceita números inteiros ou decimais (0.0) positivos.");
        }

        [Theory(DisplayName = nameof(ValidarErrorQuandoMesMenorQueDois))]
        [Trait("Domain", "CDB - Aggregates")]
        [InlineData(-2)]
        [InlineData(-1)]
        [InlineData(1)]
        public void ValidarErrorQuandoMesMenorQueDois(int mes)
        {
            var cdbValido = _fixture.ObterCDBValido();

            Action action = () => new CDB(cdbValido.ValorMonetario, mes);

            action.Should()
                .Throw<EntityValidationException>()
                .WithMessage("O campo Mes, só aceita números inteiros maior que o número 1 (Um).");
        }
    }
}
