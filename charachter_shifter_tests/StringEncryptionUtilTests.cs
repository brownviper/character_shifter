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
        public void encrypt_should_return_Hello_World()
        {
            Assert.AreEqual("Hello world!", shiftingUtil.encrypt("Zwddg ogjdv!", 8));
        }
    }
}
