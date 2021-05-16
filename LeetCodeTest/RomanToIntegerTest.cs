using LeetCode;
using Xunit;

namespace LeetCodeTest
{
    public class RomanToIntegerTest
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(6, "VI")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(40, "XL")]
        [InlineData(90, "XC")]
        [InlineData(400, "CD")]
        [InlineData(900, "CM")]
        [InlineData(31, "XXXI")]
        public void Test1(int expected, string input)
        {
            var container = new RomanToInteger();
            var result = container.RomanToInt(input);

            Assert.Equal(expected, result);
        }
    }
}