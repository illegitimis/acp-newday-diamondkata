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

        [Theory(Skip = "TDD, implementation throws not implemented exception")]
        [InlineData('A', 1, 1, 1, A111)]
        [InlineData('A', 1, 1, 1, A322)]
        [InlineData('A', 5, 3, 3, A533)]
        [InlineData('B', 3, 1, 3, B313)]
        [InlineData('B', 5, 2, 4, B524)]
        [InlineData('C', 5, 1, 5, C515)]
        public void Produce(char letter, int length, int left, int right, string expected)
        {
            var chars = Sut.Build(letter,length,left,right);
            var actual = chars.ToString();
            Assert.Equal(expected, actual);
        }
    }
}