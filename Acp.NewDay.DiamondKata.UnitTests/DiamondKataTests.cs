using Xunit;

namespace Acp.NewDay.DiamondKata.UnitTests
{
    public class DiamondKataTests
    {
        static readonly IDiamondKata Sut = new DiamondKata();

        const string A = "A";

        const string B = @"
            _A_
            B_B
            _A_
        ";

        const string C = @"
            __A__
            _B_B_
            C___C
            _B_B_
            __A__
        ";

        [Fact]
        public void A1()
        {
            var expected = Sut.Print('A');
            Assert.Equal(expected, A);
        }

        [Fact(Skip = "TDD, implementation throws not implemented exception")]
        public void B2()
        {
            var expected = Sut.Print('B');
            Assert.Equal(expected, B);
        }

        [Fact(Skip = "TDD, implementation throws not implemented exception")]
        public void C3()
        {
            var expected = Sut.Print('C');
            Assert.Equal(expected, C);
        }
    }
}