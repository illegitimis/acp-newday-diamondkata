using System;
using Xunit;

namespace Acp.NewDay.DiamondKata.UnitTests
{
    public class LineBuilderTests
    {
        static readonly ILineBuilder Sut = new LineBuilder();

        /*
         * Const naming: 3 indices
         * First: length
         * Second: left most letter
         * Third: right most letter
         */

        const string A111 = "A";
        const string A322 = "_A_";
        const string A533 = "__A__";
        const string B313 = "B_B";
        const string B524 = "_B_B_";
        const string C515 = "C___C";

        [Theory]
        [InlineData('A', 1, 1, 1, A111)]
        [InlineData('A', 3, 2, 2, A322)]
        [InlineData('A', 5, 3, 3, A533)]
        [InlineData('B', 3, 1, 3, B313)]
        [InlineData('B', 5, 2, 4, B524)]
        [InlineData('C', 5, 1, 5, C515)]
        public void ShouldProduceLineCharacters(char letter, uint length, uint left, uint right, string expected)
        {
            var chars = Sut.Build(letter, length, left, right);
            var actual = new string(chars);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData('1')]
        [InlineData('9')]
        [InlineData('=')]
        [InlineData('+')]
        public void DigitsAndPunctuationNotLetters(char c)
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => Sut.Build(c, 0, 0, 0));
            Assert.Contains(LineBuilder.LettersOnly, ex.Message);
        }

        [Fact]
        public void LeftHigherThanRightNotSupported()
        {
            var ex = Assert.Throws<NotSupportedException>(() => Sut.Build('c', 100, 10, 0));
            var s = LineBuilder.NotSupported("left", 10, "right", 0);
            Assert.Equal(s, ex.Message);
        }

        [Fact]
        public void LeftHigherThanLengthNotSupported()
        {
            var ex = Assert.Throws<NotSupportedException>(() => Sut.Build('c', 0, 10, 13));
            var s = LineBuilder.NotSupported("left", 10, "length", 0);
            Assert.Equal(s, ex.Message);
        }

        [Fact]
        public void RightHigherThanLengthNotSupported()
        {
            var ex = Assert.Throws<NotSupportedException>(() => Sut.Build('c', 17, 10, 85));
            var s = LineBuilder.NotSupported("right", 85, "length", 17);
            Assert.Equal(s, ex.Message);
        }
    }
}