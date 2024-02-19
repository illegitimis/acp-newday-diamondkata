namespace Acp.NewDay.DiamondKata
{
    /// <summary>
    /// <inheritdoc cref="ILineBuilder"/>
    /// </summary>
    public class LineBuilder : ILineBuilder
    {
        public char[] Build(char letter, int length, int left, int right)
        {
            if (!char.IsLetter(letter)) throw new ArgumentOutOfRangeException(nameof(letter), letter, LettersOnly);
            if(left > right) throw new NotSupportedException($"Left {left} should be less than or equal to right {right}");
            if (left > length) throw new NotSupportedException($"Left {left} should be less than or equal to length {length}");
            if (right > length) throw new NotSupportedException($"Right {right} should be less than or equal to length {length}");

            throw new NotImplementedException();
        }

        internal const string LettersOnly = "Only letters accepted";
    }
}