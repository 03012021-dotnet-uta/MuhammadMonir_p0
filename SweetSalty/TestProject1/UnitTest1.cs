using SweetSalty;
using System;
using Xunit;

namespace TestProject1
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
