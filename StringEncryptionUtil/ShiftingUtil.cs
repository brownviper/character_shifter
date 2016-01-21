using System;
using System.Text;

namespace StringEncryptionUtil
{
    public class ShiftingUtil
    {
        public string encrypt(string input, int shift)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var c in input)
            {
                if (char.IsSymbol(c) || char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                    continue;
                }


                char shifted;

                if (char.IsLower(c))
                {
                    shifted = shiftLowerLetter(c, shift);
                }
                else
                {
                    shifted = shiftUpperLetter(c, shift);
                }

                sb.Append(shifted);
            }

            return sb.ToString();
        }

        private static char shiftUpperLetter(char c, int shift)
        {
            if (c == 'Z')
                return Convert.ToChar('A' + shift - 1);

            return Convert.ToChar(c + shift);
        }

        private static char shiftLowerLetter(char c, int shift)
        {
            if (c == 'z')
                return Convert.ToChar('a' + shift - 1);

            return Convert.ToChar(c + shift);
        }
    }
}