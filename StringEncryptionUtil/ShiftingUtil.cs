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
                var shifted = Convert.ToChar(c+shift);
                sb.Append(shifted);
            }

            return sb.ToString();
        }
    }
}