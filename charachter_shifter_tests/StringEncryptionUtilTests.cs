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

        [Test]
        public void encrypt_should_shift_zs_by_two_shifts_to_bs()
        {
            Assert.AreEqual("b b", shiftingUtil.encrypt("z z", 2));
        }

        [Test]
        public void when_input_Z_output_should_wrap_to_A()
        {
            Assert.AreEqual("A", shiftingUtil.encrypt("Z", 1));
        }

        [Test]
        public void encrypt_should_shift_Z_by_two_shifts_to_B()
        {
            Assert.AreEqual("B", shiftingUtil.encrypt("Z", 2));
        }

        [Test]
        public void encrypt_should_shift_Zs_by_two_shifts_to_Bs()
        {
            Assert.AreEqual("A B", shiftingUtil.encrypt("Y Z", 2));
        }

        [Test]
        public void encrypt_should_shift_more_that_one_small_letters_to_wrap()
        {
            Assert.AreEqual("b d", shiftingUtil.encrypt("x z", 4));
        }
    }
}
