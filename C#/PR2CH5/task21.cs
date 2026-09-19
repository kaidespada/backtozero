using System;

namespace PR2CH4
{
    internal static class task21
    {
        public static void Run()
        {
            string pass = "ValidPass1";
            bool isValid = ValidatePassword(pass);
            Console.WriteLine($"Пароль '{pass}' валиден: {isValid}");
        }

        static bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            bool HasDigit()
            {
                foreach (char c in password)
                {
                    if (char.IsDigit(c)) return true;
                }
                return false;
            }

            bool HasUpper()
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) return true;
                }
                return false;
            }

            bool HasValidLength()
            {
                return password.Length >= 8;
            }

            return HasDigit() && HasUpper() && HasValidLength();
        }
    }
}