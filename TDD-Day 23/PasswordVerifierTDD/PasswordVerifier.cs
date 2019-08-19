using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordVerifierTDD
{
    public class PasswordVerifier
    {
        public static bool Verify(string password)
        {
            bool result = false;
            if (password.Length > 7)
            {
                result = true;
            }
            if (result)
            {
                result = false;
                foreach (char letter in password)
                {
                    if (char.IsUpper(letter))
                    {
                        result = true;             
                    }
                }
            }
            if (result)
            {
                result = false;
                foreach(char letter in password)
                {
                    if (char.IsNumber(letter))
                    {
                        result = true;
                    }
                }

            }
            return result;

        }
    }
}
