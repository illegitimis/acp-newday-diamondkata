namespace Acp.NewDay.DiamondKata
{
    /// <summary>
    /// <inheritdoc cref="IDiamondKata"/>
    /// </summary>
    public class DiamondKata : IDiamondKata
    {
        public string Print(char letter)
        {
            return letter switch
            {
                'A' or 'a' => "A",
                _ => throw new NotImplementedException()
            };
        }
    }
}