﻿namespace Acp.NewDay.DiamondKata
{
    /// <summary>
    /// <inheritdoc cref="ILineBuilder"/>
    /// </summary>
    public class LineBuilder : ILineBuilder
    {
        public char[] Build(char letter, int length, int left, int right)
        {
            if (!char.IsLetter(letter)) throw new ArgumentOutOfRangeException(nameof(letter), letter, LettersOnly);
            if (left > right) throw new NotSupportedException(NotSupported(nameof(left), left, nameof(right), right));
            if (left > length) throw new NotSupportedException(NotSupported(nameof(left), left, nameof(length), length));
            if (right > length) throw new NotSupportedException(NotSupported(nameof(right), right, nameof(length), length));

            throw new NotImplementedException();
        }

        internal const string LettersOnly = "Only letters accepted";

        internal static string NotSupported(
            string notSupportedString,
            int notSupported,
            string referenceString,
            int reference) =>
            $"{notSupportedString} {notSupported} should be less than or equal to {referenceString} {reference}";
    }
}