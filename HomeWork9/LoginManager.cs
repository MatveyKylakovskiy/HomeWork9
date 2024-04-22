
using HomeWork9.MyExceptions;

namespace HomeWork9
{
    public static class LoginManager
    {
        private static int _lineLength = 20;

        public static bool ConfirmerLogin(string login, string password, string confirmPassword)
        {
            bool result = true;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                result = false;
                throw new ArgumentException();
            }

            if (!(LoginManager.IsCorrectLine(login)))
            {
                result = false;
                throw new WrongLoginException("WrongLoginException");
            }

            if (!(LoginManager.IsCorrectLine(password)) || !(LoginManager.IsContainsDigit(password)))
            {
                result = false;
                throw new WrongPasswordException("The password is not equal to confirmPassword");
            }

            if (password != confirmPassword)
            {
                result = false;
                throw new WrongPasswordException("The password is not equal to confirmPassword");
            }

            return result;
        }

        private static bool IsCorrectLine(string str)
        {
            return ((str.Length < _lineLength && str.IndexOf(" ") == -1));
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
