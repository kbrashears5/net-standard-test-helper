using System;
using System.Collections.Generic;

namespace NetStandardTestHelper
{
    /// <summary>
    /// Test values
    /// </summary>
    public static class TestValues
    {
        /// <summary>
        /// Represents an empty <see cref="EventArgs"/>
        /// </summary>
        public static EventArgs EventArgsEmpty { get; } = EventArgs.Empty;

        /// <summary>
        /// Represents an empty <see cref="Exception"/>
        /// </summary>
        public static Exception ExceptionEmpty { get; } = new Exception();

        /// <summary>
        /// Represents an empty string IEnumerable
        /// </summary>
        public static IEnumerable<string> IEnumerableStringEmpty { get; } = new List<string>();

        /// <summary>
        /// Represents a null string IEnumerable
        /// </summary>
        public static IEnumerable<string> IEnumerableStringNull { get; }

        /// <summary>
        /// Represents an empty object
        /// </summary>
        public static object ObjectEmpty { get; } = new object();

        /// <summary>
        /// Represents a null object
        /// </summary>
        public static object ObjectNull { get; } = null;

        /// <summary>
        /// Represents a basic string
        /// </summary>
        public static string String { get; } = nameof(String);

        /// <summary>
        /// Represents an empty string
        /// </summary>
        public static string StringEmpty { get; } = string.Empty;
    }
}