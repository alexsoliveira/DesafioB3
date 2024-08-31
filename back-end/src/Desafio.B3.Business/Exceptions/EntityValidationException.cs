namespace Desafio.B3.Business.Exceptions
{
    public class EntityValidationException : Exception
    {
        public EntityValidationException(string? message) : base(message)
        {
        }
    }
}
