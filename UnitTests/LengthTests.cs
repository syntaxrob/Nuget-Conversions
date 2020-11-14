using System;
using Conversions;
using Xunit;

namespace UnitTests
{
    public class LengthTests
    {
        [Fact]
        public void KilometerToMeter()
        {
            double expected = 1000;
            double actual = Length.KilometerToMeter(1);
            Assert.Equal(expected, actual);
        }
    }
}
