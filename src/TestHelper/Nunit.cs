using System;
using NUnit.Framework;

namespace NetStandardTestHelper.NUnit
{
    /// <summary>
    /// Functions to help unit testing with NUnit
    /// </summary>
    public static class TestHelper
    {
        /// <summary>
        /// While you can use Assert.Throws(), this method asserts that the correct parameter was thrown
        /// </summary>
        /// <param name="exception">Exception to check</param>
        /// <param name="parameterName">Parameter name to assert is null</param>
        /// <param name="netType">.NET runtime. Defaults to <see cref="NetType.NetStandard"/></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void AssertArgumentNullException(ArgumentNullException exception,
            string parameterName,
            NetType netType = NetType.NetStandard)
        {
            if (exception == null) throw new ArgumentNullException(nameof(exception));
            if (string.IsNullOrWhiteSpace(parameterName)) throw new ArgumentNullException(nameof(parameterName));

            string exceptionText;

            switch (netType)
            {
                case NetType.Net35Plus:
                    exceptionText = Text.ArgumentNullNet35(paramName: parameterName);
                    break;

                default:
                    exceptionText = Text.ArgumentNullNetStandard(paramName: parameterName);
                    break;
            }

            AssertExceptionText(exception: exception,
                expectedExceptionText: exceptionText);
        }

        /// <summary>
        /// Assert that the Exception text is what was expected
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="expectedExceptionText"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void AssertExceptionText(Exception exception,
            string expectedExceptionText)
        {
            if (exception == null) throw new ArgumentNullException(nameof(exception));
            if (string.IsNullOrWhiteSpace(expectedExceptionText)) throw new ArgumentNullException(nameof(expectedExceptionText));

            Assert.AreEqual(expectedExceptionText,
                exception.Message);
        }

        /// <summary>
        /// Assert that the InnerException text is what was expected
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="expectedExceptionText"></param>
        public static void AssertInnerExceptionText(Exception exception,
            string expectedExceptionText)
        {
            if (exception == null) throw new ArgumentNullException(nameof(exception));
            if (string.IsNullOrWhiteSpace(expectedExceptionText)) throw new ArgumentNullException(nameof(expectedExceptionText));

            if (exception.InnerException == null) throw new NullReferenceException(nameof(exception.InnerException));

            AssertExceptionText(exception: exception.InnerException,
                expectedExceptionText: expectedExceptionText);
        }
    }
}