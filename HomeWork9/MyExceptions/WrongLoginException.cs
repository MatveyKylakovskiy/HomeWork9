
namespace HomeWork9.MyExceptions
{
    public class WrongLoginException: Exception
    {   
      public readonly string Message;
      public WrongLoginException()
        {
            Message = "WrongLoginException";
        }

    }
}
