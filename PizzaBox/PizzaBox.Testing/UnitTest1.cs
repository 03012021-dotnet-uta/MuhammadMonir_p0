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
            { Name = "tahir" };

            var expected = "tahir";

            var result = cust.Name;

            Assert.Equal(result, expected);

        }

        [Theory]
        [InlineData("user 1")]
        public void Test2(string expected)
        {
            var sut = new Customer()
            {
                Name = "user 1"
            };



            var actual = sut.Name;


            Assert.Equal(expected, actual);

        }
    }
}
