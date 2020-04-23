using NetStandardTestHelper.Xunit;
using System;
using Xunit;

namespace NetStandardTestHelper.Test
{
    /// <summary>
    /// Test the <see cref="TestHelper"/> class
    /// </summary>
    public class TestHelper_Tests
    {
        #region AssertArgumentNullException

        /// <summary>
        /// Test that function throws for null exception parameter
        /// </summary>
        [Fact]
        public void AssertArgumentNullException_Null_Exception()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => TestHelper.AssertArgumentNullException(exception: null,
                parameterName: TestValues.String));
        }

        /// <summary>
        /// Test that function throws for null parameterName parameter
        /// </summary>
        [Fact]
        public void AssertArgumentNullException_Null_ParameterName()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => TestHelper.AssertArgumentNullException(exception: new ArgumentNullException(),
                parameterName: TestValues.StringEmpty));
        }

        /// <summary>
        /// Test that function asserts <see cref="ArgumentNullException"/> text
        /// </summary>
        [Fact]
        public void AssertArgumentNullException()
        {
            var exception = new ArgumentNullException(TestValues.String);

            TestHelper.AssertArgumentNullException(exception: exception,
                parameterName: TestValues.String);
        }

        #endregion AssertArgumentNullException

        #region AssertExceptionText

        /// <summary>
        /// Test that function throws for null exception parameter
        /// </summary>
        [Fact]
        public void AssertExceptionText_Null_Exception()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => TestHelper.AssertExceptionText(exception: null,
                expectedExceptionText: TestValues.String));
        }

        /// <summary>
        /// Test that function throws for null expectedExceptionText parameter
        /// </summary>
        [Fact]
        public void AssertExceptionText_Null_ExpectedExceptionText()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => TestHelper.AssertExceptionText(exception: new ArgumentNullException(),
                expectedExceptionText: TestValues.StringEmpty));
        }

        /// <summary>
        /// Test that function asserts <see cref="NullReferenceException"/> text
        /// </summary>
        [Fact]
        public void AssertExceptionText_NullReferenceException()
        {
            var exception = new NullReferenceException(TestValues.String);

            TestHelper.AssertExceptionText(exception: exception,
                expectedExceptionText: TestValues.String);
        }

        /// <summary>
        /// Test that function asserts <see cref="OverflowException"/> text
        /// </summary>
        [Fact]
        public void AssertExceptionText_OverflowException()
        {
            var exception = new OverflowException(TestValues.String);

            TestHelper.AssertExceptionText(exception: exception,
                expectedExceptionText: TestValues.String);
        }

        #endregion AssertExceptionText
    }
}