

using HomeWork9.MyExceptions;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace HomeWork9
{
    public static class LoginManager
    {
        private static int _lineLength = 20;
        private static bool result = true;

        public static bool ConfirmerLogin(string login, string password, string confirmPassword)
        {   
            try
            {   if(login is null || password is null || confirmPassword is null)
                {   
                    result = false;
                    throw new NullReferenceException();
                }

                if(login == "" || password == "" ||  confirmPassword == "")
                {
                    result = false;
                    throw new ArgumentException();
                }

                if (LoginManager.IsCorrectLine(login) == false)
                {
                    result = false;
                    throw new WrongLoginException();
                }

                if (LoginManager.IsCorrectLine(password) == false || LoginManager.IsConteinDigit(password) == false)
                {
                    result = false;
                    throw new WrongPasswordException("The password is longer than 20 characters or does not contain numbers");
                }

                if (password != confirmPassword)
                {
                    result = false;
                    throw new WrongPasswordException("The password is not equal to confirmPassword");
                }
            }

            catch(ArgumentException ex)
            {
                Console.WriteLine(ex);
            }

            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex);
            }

            catch(WrongLoginException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(WrongPasswordException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;

        }

        private static bool IsCorrectLine(string str)
        {

            if (str.Length < _lineLength && str.IndexOf(" ") == -1)
            {
                return true;
            }
                return false;
        }

        private static bool IsConteinDigit(string str)
        {
            foreach (var s in str)
            {
                if (Char.IsDigit(s))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
