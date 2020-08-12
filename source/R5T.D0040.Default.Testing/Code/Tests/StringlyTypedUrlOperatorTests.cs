using System;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.D0040.Testing;


namespace R5T.D0040.Default.Testing
{
    [TestClass]
    public class StringlyTypedUrlOperatorTests : StringlyTypedUrlOperatorTestFixture
    {
        #region Static

        private static ServiceProvider ServiceProvider { get; set; }


        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            StringlyTypedUrlOperatorTests.ServiceProvider = Utilities.GetServiceProvider();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            StringlyTypedUrlOperatorTests.ServiceProvider.Dispose();
        }

        #endregion


        public StringlyTypedUrlOperatorTests()
            : base(StringlyTypedUrlOperatorTests.ServiceProvider)
        {
        }
    }
}
