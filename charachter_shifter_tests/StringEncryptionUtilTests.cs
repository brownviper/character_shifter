using NUnit.Framework;
using StringEncryptionUtil;

namespace charachter_shifter_tests
{
    [TestFixture]
    public class StringEncryptionUtilTests
    {
        [Test]
        public void _Test()
        {
            var shiftingUtil = new ShiftingUtil();
            Assert.NotNull(shiftingUtil);
        }
    }
}
