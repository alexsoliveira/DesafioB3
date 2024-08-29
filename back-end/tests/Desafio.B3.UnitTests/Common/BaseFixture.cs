using Bogus;

namespace Desafio.B3.UnitTests.Common
{
    public abstract class BaseFixture
    {
        public Faker Faker { get; set; }

        public BaseFixture()
            => Faker = new Faker("pt_BR");
    }
}
