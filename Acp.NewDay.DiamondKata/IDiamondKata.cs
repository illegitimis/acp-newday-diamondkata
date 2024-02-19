namespace Acp.NewDay.DiamondKata;

/// <summary>
/// Contract for NewDay DiamondKata recruitment test
/// </summary>
public interface IDiamondKata
{
    /// <summary>
    /// Composes a diamond like string as specified in <see cref="https://github.com/NewDayTechnology/RecruitmentTests/blob/main/DiamondKata/README.md"/>
    /// </summary>
    /// <param name="letter">
    /// letter of the alphabet
    /// </param>
    /// <returns>
    /// Diamond kata string
    /// </returns>
    string Print(char letter);
}