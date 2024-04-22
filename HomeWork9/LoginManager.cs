
using HomeWork9.MyExceptions;

namespace HomeWork9
{
    public static class LoginManager
    {
        private static int _lineLength = 20;

        public static bool ConfirmerLogin(string login, string password, string confirmPassword)
        {

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                throw new ArgumentException();
            }

            if (!(LoginManager.IsCorrectLine(login)))
            {
                throw new WrongLoginException("ghiuih");
            }

            if (!(LoginManager.IsCorrectLine(password)) || !(LoginManager.IsContainsDigit(password)))
            {
                throw new WrongPasswordException("The password is not equal to confirmPassword");
            }

            if (password != confirmPassword)
            {
                throw new WrongPasswordException("The password is not equal to confirmPassword");
            }

            return true;
        }

        private static bool IsCorrectLine(string str)
        {


            if ((str.Length < _lineLength && str.IndexOf(" ") == -1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsContainsDigit(string str)
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
