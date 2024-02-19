using System.Text;

namespace Acp.NewDay.DiamondKata
{
    /// <summary>
    /// <inheritdoc cref="IDiamondKata"/>
    /// </summary>
    public class DiamondKata : IDiamondKata
    {
        private readonly ILineBuilder _lineBuilder;

        public DiamondKata(ILineBuilder lineBuilder)
        {
            _lineBuilder = lineBuilder;
        }

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
                var chars = _lineBuilder.Build(c, lineLength, left, right);
                Append(chars);
                stack.Push(chars);
                right++;
                left--;
            }

            stack.Pop();

            while (stack.Any()) Append(stack.Pop());

            return sb.ToString();

            void Append(char[] chars)
            {
                sb.Append(chars);
                sb.Append(Environment.NewLine);
            }
        }
    }
}