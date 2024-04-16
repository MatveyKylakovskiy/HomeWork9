
namespace HomeWork9.MyExceptions
{
    public class WrongPasswordException: Exception
    {
        public readonly string Message;
        public WrongPasswordException(string message)
        {
            Message = string.Format("WrongPasswordException. {0}", message);
        }
    }
}
