using System;
using NUnit.Framework;

namespace NetStandardTestHelper.Test
{
    /// <summary>
    /// Test the <see cref="NUnit.TestHelper"/> class
    /// </summary>
    [TestFixture]
    public class NUnit_Tests
    {
        #region AssertArgumentNullException

        /// <summary>
        /// Test that function throws for null exception parameter
        /// </summary>
        [TestCase]
        public void AssertArgumentNullException_Null_Exception()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => NUnit.TestHelper.AssertArgumentNullException(exception: null,
                parameterName: TestValues.String));
        }

        /// <summary>
        /// Test that function throws for null parameterName parameter
        /// </summary>
        [TestCase]
        public void AssertArgumentNullException_Null_ParameterName()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => NUnit.TestHelper.AssertArgumentNullException(exception: new ArgumentNullException(),
                parameterName: TestValues.StringEmpty));
        }

        /// <summary>
        /// Test that function asserts <see cref="ArgumentNullException"/> text
        /// </summary>
        [TestCase]
        public void AssertArgumentNullException()
        {
            var exception = new ArgumentNullException(TestValues.String);

            NUnit.TestHelper.AssertArgumentNullException(exception: exception,
                parameterName: TestValues.String);
        }

        #endregion AssertArgumentNullException

        #region AssertExceptionText

        /// <summary>
        /// Test that function throws for null exception parameter
        /// </summary>
        [TestCase]
        public void AssertExceptionText_Null_Exception()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => NUnit.TestHelper.AssertExceptionText(exception: null,
                expectedExceptionText: TestValues.String));
        }

        /// <summary>
        /// Test that function throws for null expectedExceptionText parameter
        /// </summary>
        [TestCase]
        public void AssertExceptionText_Null_ExpectedExceptionText()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => NUnit.TestHelper.AssertExceptionText(exception: new ArgumentNullException(),
                expectedExceptionText: TestValues.StringEmpty));
        }

        /// <summary>
        /// Test that function asserts <see cref="NullReferenceException"/> text
        /// </summary>
        [TestCase]
        public void AssertExceptionText_NullReferenceException()
        {
            var exception = new NullReferenceException(TestValues.String);

            NUnit.TestHelper.AssertExceptionText(exception: exception,
                expectedExceptionText: TestValues.String);
        }

        /// <summary>
        /// Test that function asserts <see cref="OverflowException"/> text
        /// </summary>
        [TestCase]
        public void AssertExceptionText_OverflowException()
        {
            var exception = new OverflowException(TestValues.String);

            NUnit.TestHelper.AssertExceptionText(exception: exception,
                expectedExceptionText: TestValues.String);
        }

        #endregion AssertExceptionText
    }
}