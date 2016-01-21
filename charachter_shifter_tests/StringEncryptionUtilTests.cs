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

        [Test]
        public void when_input_is_capital_output_is_also_capital()
        {
            Assert.AreEqual(shiftingUtil.encrypt("A", 1), "B");
        }

        [Test]
        public void encryptio_perserve_whitespaces()
        {
            Assert.AreEqual(shiftingUtil.encrypt("A B", 1), "B C");
        }

    }
}
