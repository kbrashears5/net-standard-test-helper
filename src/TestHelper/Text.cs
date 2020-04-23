using System;

namespace NetStandardTestHelper
{
    /// <summary>
    /// Static text class for the <see cref="NetStandardTestHelper"/> namespace
    /// </summary>
    internal static class Text
    {
        internal static string ArgumentNullNet35(string paramName)
        {
            if (string.IsNullOrWhiteSpace(paramName)) throw new ArgumentNullException(nameof(paramName));

            return $"Value cannot be null.\r\nParameter name: {paramName}";
        }

        internal static string ArgumentNullNetStandard(string paramName)
        {
            if (string.IsNullOrWhiteSpace(paramName)) throw new ArgumentNullException(nameof(paramName));

            return $"Value cannot be null. (Parameter '{paramName}')";
        }
    }
}