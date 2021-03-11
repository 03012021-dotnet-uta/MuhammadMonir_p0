using System;
using Xunit;


namespace SweetNSalty.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestSweet()
        {
            var res = Program.MySweetNSalty(3);
            var expected = "Sweet";

            Assert.Equal(res, expected);

        }
    }
}
