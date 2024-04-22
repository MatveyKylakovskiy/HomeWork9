
namespace HomeWork9.MyExceptions
{
    public class WrongLoginException: Exception
    {   
        public WrongLoginException()
        {

        }

        public WrongLoginException(string message)
            : base(message)
        {

        }

        public WrongLoginException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
