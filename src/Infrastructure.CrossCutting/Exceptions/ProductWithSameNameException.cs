namespace Infrastructure.CrossCutting.Exceptions
{
    using System;

    public class ProductWithSameNameException : Exception
    {
        public ProductWithSameNameException()
        {
        }

        public ProductWithSameNameException(string message) 
            : base(message)
        {
        }

        public ProductWithSameNameException(string message, Exception exception) 
            : base(message, exception)
        {
        }
    }
}
