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

                if (c != ' ')
                {
                    if (c == 'z')
                        shifted = 'a';
                    else
                    shifted = Convert.ToChar(c + shift);
                }
                else
                {
                    shifted = Convert.ToChar(c);
                }

                sb.Append(shifted);
            }

            return sb.ToString();
        }
    }
}