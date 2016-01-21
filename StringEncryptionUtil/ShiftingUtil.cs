using System;
using System.Text;

namespace StringEncryptionUtil
{
    public class ShiftingUtil
    {
        public string encrypt(string input, int shift)
        {
            var sb = new StringBuilder();

            foreach (var c in input)
            {
                if (!char.IsLetter(c))
                {
                    sb.Append(c);
                    continue;
                }

                sb.Append(shiftLetter(c, shift));
            }

            return sb.ToString();
        }

        private static char shiftLetter(char c, int shift)
        {
            var shifted = c + shift;

            if ((shifted > 'Z' && shifted < 'a')
                               ||
                           shifted > 'z')
                return Convert.ToChar(shifted - 26);

            return Convert.ToChar(shifted);
        }
    }
}