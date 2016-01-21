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
                    if (c == 'z')
                    {
                        shifted = shiftLowerLetter(shift);
                    }
                    else
                    {
                        shifted = Convert.ToChar(c + shift);
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

        private static char shiftLowerLetter(int shift)
        {
            return Convert.ToChar('a' + shift - 1);
        }
    }
}