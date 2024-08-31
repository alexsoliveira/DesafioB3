using Bogus;
using Desafio.B3.Business.Exceptions;
using Desafio.B3.Business.Validation;
using FluentAssertions;
using CdbValidation = Desafio.B3.Business.Domain.CdbValidation;

namespace Desafio.B3.UnitTests.Validation
{
    public class DomainValidationTest
    {
        private Faker Faker { get; set; } = new Faker();        

        [Theory(DisplayName = nameof(ApenasNumeros))]
        [Trait("Domain", "DomainValidation - Validation")]        
        [InlineData("a")]
        [InlineData("  ")]
        [InlineData(null)]
        public void ApenasNumeros(string valorMonetario)
        {            
            Action action =
                () => DomainValidation.ApenasNumeros(valorMonetario, "Monetário");            

            action.Should()
                .Throw<EntityValidationException>()
                .WithMessage("O campo Monetário, só aceita números inteiros ou decimais (0.0) positivos.");
        }

        [Theory(DisplayName = nameof(ApenasNumerosPositivos))]
        [Trait("Domain", "DomainValidation - Validation")]
        [InlineData(-1)]
        [InlineData(-1000)]
        [InlineData(-111)]
        public void ApenasNumerosPositivos(double valorMonetario)
        {
            Action action =
                () => CdbValidation.ApenasNumerosPositivos(valorMonetario, "Monetário");

            action.Should()
                .Throw<EntityValidationException>()
                .WithMessage("O campo Monetário, só aceita números inteiros ou decimais (0.0) positivos.");
        }

        [Theory(DisplayName = nameof(ApenasNumerosInteiros))]
        [Trait("Domain", "DomainValidation - Validation")]
        [InlineData("a")]
        [InlineData("")]
        [InlineData(null)]
        public void ApenasNumerosInteiros(string mes)
        {

            Action action =
                () => DomainValidation.ApenasNumerosInteiros(mes, "Mês");

            action.Should()
                .Throw<EntityValidationException>()
                .WithMessage("O campo Mês, só aceita números inteiros.");
        }

        [Theory(DisplayName = nameof(ApenasNumerosInteirosMaiorQueUm))]
        [Trait("Domain", "DomainValidation - Validation")]
        [InlineData(-1)]
        [InlineData(-1000)]
        [InlineData(0)]
        [InlineData(1)]
        public void ApenasNumerosInteirosMaiorQueUm(int mes)
        {
            Action action =
                () => CdbValidation.ApenasNumerosInteirosMaiorQueUm(mes, "Mês");

            action.Should()
                .Throw<EntityValidationException>()
                .WithMessage("O campo Mês, só aceita números inteiros maior que o número 1 (Um).");
        }
    }
}
