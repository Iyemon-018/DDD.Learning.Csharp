namespace DDD.Domain.Exceptions
{
    public sealed class MessageException : ExceptionBase
    {
        public MessageException(ExceptionType exceptionType
                              , string message) : base(exceptionType, message)
        {
        }
    }
}