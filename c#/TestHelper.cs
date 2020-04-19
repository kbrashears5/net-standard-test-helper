using System;
using Xunit;
using System.Reflection;

namespace TestHelper
{
    public static class TestHelper
    {

        /// <summary>
        /// While you can use Assert.Throws(), this method asserts that the correct parameter was thrown
        /// </summary>
        /// <param name="ex">Exception to check</param>
        /// <param name="paramName">Paramater name to assert was null</parm>
        public static void AssertArgumentNullException(ArgumentNullException ex,
            string paramName)
        {
            var exceptionText = $"Value cannot be null.\r\nParameter name: {paramName}";

            AssertExceptionText(ex,
                exceptionText);
        }

        /// <summary>
        /// Assert that the Exception text is what was expected
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="expectedExceptionText"></param>
        public static void AssertExceptionText(Exception ex,
            string expectedExceptionText)
        {
            Assert.Equal(expectedExceptionText,
                ex.Message);
        }
    }
}