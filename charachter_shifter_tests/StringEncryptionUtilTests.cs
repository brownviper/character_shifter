using NUnit.Framework;
using NUnit.Framework.Internal;
using StringEncryptionUtil;

namespace charachter_shifter_tests
{
    [TestFixture]
    public class StringEncryptionUtilTests
    {
        private ShiftingUtil shiftingUtil;

        [SetUp]
        public void setup()
        {
            shiftingUtil = new ShiftingUtil();
        }

        [Test]
        public void encrypt_return_input_string()
        {
            Assert.AreEqual(shiftingUtil.encrypt("a", 0), "a");
        }

        [Test]
        public void encrypt_will_return_shifted_input_string_by_shift_key()
        {
            Assert.AreEqual(shiftingUtil.encrypt("a", 1), "b");
        }
    
    }
}
