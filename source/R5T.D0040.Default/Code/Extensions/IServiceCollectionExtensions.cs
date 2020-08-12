using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0040.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="StringlyTypedUrlOperator"/> implementation of <see cref="IStringlyTypedUrlOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddStringlyTypedUrlOperator(this IServiceCollection services)
        {
            services.AddSingleton<IStringlyTypedUrlOperator, StringlyTypedUrlOperator>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="StringlyTypedUrlOperator"/> implementation of <see cref="IStringlyTypedUrlOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IStringlyTypedUrlOperator> AddStringlyTypedUrlOperatorAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IStringlyTypedUrlOperator>(() => services.AddStringlyTypedUrlOperator());
            return serviceAction;
        }
    }
}
