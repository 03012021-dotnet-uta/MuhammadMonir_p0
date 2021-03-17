using PizzaBox.Domain;
using PizzaBox;
using Xunit;
using Microsoft.IdentityModel.Tokens;
using PizzaBox.Domain.Models;

namespace PizzaBox.Testing
{
    public class TestCustomer
    {
        [Fact]
        public void Test1()
        {
            var cust = new Customer()
            { FName = "tahir" };

            var expected = "tahir";

            var result = cust.FName;

            Assert.Equal(result, expected);

        }

        [Theory]
        [InlineData("user 1")]
        public void Test2(string expected)
        {
            var sut = new Customer()
            {
                FName = "user 1"
            };



            var actual = sut.FName;


            Assert.Equal(expected, actual);

        }
    }
}
