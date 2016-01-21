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
            Assert.AreEqual(shiftingUtil.encrypt("a"), "a");
        }
    }
}
