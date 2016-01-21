using NUnit.Framework;
using StringEncryptionUtil;

namespace charachter_shifter_tests
{
    [TestFixture]
    public class StringEncryptionUtilTests
    {
        [Test]
        public void encrypt_return_input_string()
        {
            var shiftingUtil = new ShiftingUtil();
            Assert.AreEqual(shiftingUtil.encrypt("a", 0), "a");
        }

        [Test]
        public void encrypt_will_return_shifted_input_string_by_shift_key()
        {
            var shiftingUtil = new ShiftingUtil();
            Assert.AreEqual(shiftingUtil.encrypt("a", 1), "b");
        }
    
    }
}
