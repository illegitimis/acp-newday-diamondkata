using static Acp.NewDay.DiamondKata.LineBuilder;
using static Acp.NewDay.DiamondKata.UnitTests.LineBuilderTests;

namespace Acp.NewDay.DiamondKata.UnitTests;
public class DiamondKataTests
{
    private static readonly IDiamondPrinter Sut = new DiamondPrinter(LineBuilderTests.Sut);
    private static readonly string rn = Environment.NewLine;
    private static readonly string A = $"{A111}{rn}";

    /*
     A
    B B
     A
     */
    private static readonly string B = $"{A322}{rn}{B313}{rn}{A322}{rn}";

    /*
    _ _ A _ _
    _ B _ B _
    C _ _ _ C
    _ B _ B _
    _ _ A _ _
      */
    private static readonly string C = $"{A533}{rn}{B524}{rn}{C515}{rn}{B524}{rn}{A533}{rn}";

    public static IEnumerable<object[]> PositiveTests =>
    [
        ['A', A],
        ['B', B],
        ['C', C]
    ];

    [Theory]
    [InlineData('7')]
    [InlineData('8')]
    [InlineData('.')]
    [InlineData('>')]
    public void OnlyLettersSupported(char c)
    {
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => Sut.Print(c));
        Assert.Contains(LettersOnly, ex.Message, StringComparison.InvariantCultureIgnoreCase);
    }

    [Theory]
    [MemberData(nameof(PositiveTests))]
    public void ShouldPrintDiamond(char letter, string expected)
    {
        var actual = Sut.Print(letter);
        Assert.Equal(expected, actual);
    }
}
