
// using Console = global::System.Console;

namespace Acp.NewDay.DiamondKata.CLI;
internal static class Program
{
    private static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(options =>
            {
                var printer = new DiamondKata(new LineBuilder());
                var diamond = printer.Print(options.Letter);
                Console.WriteLine(diamond);
            })
            .WithNotParsed(errors =>
            {
                foreach (var error in errors)
                {
                    Console.WriteLine(error);
                }
            });
    }
}
