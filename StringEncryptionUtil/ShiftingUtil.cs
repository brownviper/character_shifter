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
                char shifted;

                if (char.IsLetter(c))
                {
                    if (char.IsLower(c))
                    {
                        shifted = shiftLowerLetter(c, shift);
                    }
                    else
                    {
                        shifted = shiftUpperLetter(shift, c);
                    }
                }
                else
                {
                    shifted = Convert.ToChar(c);
                }

                sb.Append(shifted);
            }

            return sb.ToString();
        }

        private static char shiftUpperLetter(int shift, char c)
        {
            char shifted;
            if (c == 'Z')
                shifted = Convert.ToChar('A' + shift - 1);
            else
                shifted = Convert.ToChar(c + shift);

            return shifted;
        }

        private static char shiftLowerLetter(char c, int shift)
        {
            if (c == 'z')
                return Convert.ToChar('a' + shift - 1);

            return Convert.ToChar(c + shift);
        }
    }
}