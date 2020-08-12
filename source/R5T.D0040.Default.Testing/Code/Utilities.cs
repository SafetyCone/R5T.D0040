using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0040.Default.Testing
{
    public static class Utilities
    {
        public static ServiceProvider GetServiceProvider()
        {
            var services = new ServiceCollection();

            // 0.
            var stringlyTypedUrlOperatorAction = services.AddStringlyTypedUrlOperatorAction();

            services
                .Run(stringlyTypedUrlOperatorAction)
                ;

            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
