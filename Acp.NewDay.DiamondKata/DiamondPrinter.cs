using System.Text;

namespace Acp.NewDay.DiamondKata;

/// <summary>
/// <inheritdoc cref="IDiamondPrinter"/>
/// </summary>
public class DiamondPrinter(ILineBuilder lineBuilder) : IDiamondPrinter
{
    public string Print(char letter)
    {
        if (!char.IsLetter(letter)) throw new ArgumentOutOfRangeException(nameof(letter), letter, LineBuilder.LettersOnly);

        // A is 65, a is 97
        char start = letter > 'a' ? 'a' : 'A';
        int delta = letter - start;
        uint lineLength = (uint)(2 * delta + 1);
        uint positionA = (uint)(delta + 1);
        uint left = positionA, right = positionA;

        var sb = new StringBuilder();

        var stack = new Stack<char[]>();
        for (char c = start; c <= letter; c++)
        {
            var chars = lineBuilder.Build(c, lineLength, left, right);
            Append(chars);
            stack.Push(chars);
            right++;
            left--;
        }

        stack.Pop();

        while (stack.Count != 0) Append(stack.Pop());

        return sb.ToString();

        void Append(char[] chars)
        {
            sb.Append(chars);
            sb.Append(Environment.NewLine);
        }
    }
}