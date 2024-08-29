using Desafio.B3.Business.Domain;
using Desafio.B3.UnitTests.Common;

namespace Desafio.B3.UnitTests.Domain
{
    [CollectionDefinition(nameof(CDBTestFixture))]
    public class CDBTestFixtureCollection
        : ICollectionFixture<CDBTestFixture>
    { }

    public class CDBTestFixture : BaseFixture
    {
        public CDBTestFixture()
            : base() { }

        public double ObterValorMonetarioValido()
        {
            var valorMonetario = 0.0;

            while (valorMonetario < 0.0)
                valorMonetario = (double)Faker.Finance.Amount(0,100000,2);            

            return valorMonetario;
        }

        public int ObterMesValido()
        {
            var mes = 0;

            if (mes < 2)
                mes = new Random().Next(2, 24);

            return mes;
        }

        public CDB ObterCDBValido()
            => new(
                ObterValorMonetarioValido(),
                ObterMesValido()
            );
    }
}

    