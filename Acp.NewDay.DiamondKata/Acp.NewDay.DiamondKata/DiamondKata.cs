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

            return letter switch
            {
                'A' or 'a' => "A",
                _ => throw new NotImplementedException()
            };
        }
    }
}