
// using Console = global::System.Console;

namespace Acp.NewDay.DiamondKata.CLI;

internal class Options
{
    [Value(0, Required = true, HelpText = "Diamond character to iterate to")]
    public char Letter { get; set; }

    [Option(longName: "whitespace", shortName: 'w', Default = '_', Required = false)]
    public char WhiteSpaceChar { get; set; }
}