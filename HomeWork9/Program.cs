using HomeWork9;
using HomeWork9.MyExceptions;

try
{
    bool check = LoginManager.ConfirmerLogin("yuyhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhu", "1f", "11f");
    Console.WriteLine(check);
}


catch (ArgumentException ex)
{
    Console.WriteLine(ex);
}

catch (WrongLoginException ex)
{
    Console.WriteLine(ex.Message);
}

catch (WrongPasswordException ex)
{
    Console.WriteLine(ex.Message);
}

catch (Exception ex)
{
    Console.WriteLine(ex);
}

