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
            Assert.AreEqual("a", shiftingUtil.encrypt("a", 0));
        }

        [Test]
        public void encrypt_will_return_shifted_input_string_by_shift_key()
        {
            Assert.AreEqual("b", shiftingUtil.encrypt("a", 1));
        }

        [Test]
        public void when_input_is_capital_output_is_also_capital()
        {
            Assert.AreEqual("B", shiftingUtil.encrypt("A", 1));
        }

        [Test]
        public void encryptio_perserve_whitespaces()
        {
            Assert.AreEqual("B C", shiftingUtil.encrypt("A B", 1));
        }

        [Test]
        public void when_input_z_output_should_wrap_to_a()
        {
            Assert.AreEqual("a", shiftingUtil.encrypt("z", 1));
        }

        [Test]
        public void encrypt_should_shift_z_by_two_shifts_to_b()
        {
            Assert.AreEqual("b", shiftingUtil.encrypt("z", 2));
        }

    }
}
