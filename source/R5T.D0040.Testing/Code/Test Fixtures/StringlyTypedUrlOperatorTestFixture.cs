using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0011;


namespace R5T.D0040.Testing
{
    public abstract class StringlyTypedUrlOperatorTestFixture : ServiceTestFixtureBase<IStringlyTypedUrlOperator>
    {
        protected IStringlyTypedUrlOperator StringlyTypedUrlOperator => this.Service; // More specific name for convenience.


        public StringlyTypedUrlOperatorTestFixture(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        /// <summary>
        /// Tests basic HTTPS url creation.
        /// </summary>
        [TestMethod]
        public void BuildHttpsUrl()
        {
            var host = "github.com";
            var path = @"SafetyCone/R5T.E0005.Private.git";
            var expected = Constants.HttpsUrl01;

            var actual = this.StringlyTypedUrlOperator.BuildHttpsUrl(host, path);

            Assert.AreEqual(expected, actual);
        }
    }
}
