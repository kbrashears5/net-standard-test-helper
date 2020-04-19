using System;
using System.Collections.Generic;

namespace TestHelper
{
    public static class TestValues
    {
        public static string EmptyString { get; } = string.Empty;

        public static object EmptyObject { get; } = new object();

        public static object NullObject { get; } = null;

        public static IEnumerable<string> NullStringList { get; }

        public static IEnumerable<string> EmptyStringList { get; } = new List<string>();

        public static EventArgs EventArgs { get; } = EventArgs.Empty;
    }
}