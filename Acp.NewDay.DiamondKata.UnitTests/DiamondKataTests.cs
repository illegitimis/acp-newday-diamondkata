using System;
using System.Collections.Generic;
using Xunit;
using static Acp.NewDay.DiamondKata.UnitTests.LineBuilderTests;

namespace Acp.NewDay.DiamondKata.UnitTests
{
    public class DiamondKataTests
    {
        static readonly IDiamondKata Sut = new DiamondKata(LineBuilderTests.Sut);

        static readonly string rn = Environment.NewLine;

        static readonly string A = $"{A111}{rn}";
        /*
         A
        B B
         A
         */
        static readonly string B = $"{A322}{rn}{B313}{rn}{A322}{rn}";
        /*
        _ _ A _ _
        _ B _ B _
        C _ _ _ C
        _ B _ B _
        _ _ A _ _
          */
        static readonly string C = $"{A533}{rn}{B524}{rn}{C515}{rn}{B524}{rn}{A533}{rn}";

        public static IEnumerable<object[]> PositiveTests => new List<object[]>
        {
            new object[] { 'A', A },
            new object[] { 'B', B },
            new object[] { 'C', C }
        };

        [Theory]
        [InlineData('7')]
        [InlineData('8')]
        [InlineData('.')]
        [InlineData('>')]
        public void LettersOnly(char c)
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => Sut.Print(c));
            Assert.Contains(LineBuilder.LettersOnly, ex.Message);
        }

        [Theory]
        [MemberData(nameof(PositiveTests))]
        public void ShouldPrintDiamond(char letter, string expected)
        {
            var actual = Sut.Print(letter);
            Assert.Equal(expected, actual);
        }
    }
}