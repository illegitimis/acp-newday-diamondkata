namespace Acp.NewDay.DiamondKata;

/// <summary>
/// Produces a line in the diamond
/// </summary>
public interface ILineBuilder
{
    /// <summary>
    /// Builds a char array representing one line in the diamond
    /// </summary>
    /// <param name="letter">alphabet letter</param>
    /// <param name="length">line length</param>
    /// <param name="left">leftmost position where letter stands</param>
    /// <param name="right">leftmost position where letter stands</param>
    /// <returns>character array for a line</returns>
    char[] Build(char letter, uint length, uint left, uint right);
}