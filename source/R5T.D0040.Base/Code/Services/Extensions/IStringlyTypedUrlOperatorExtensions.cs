using System;

using NetConstants = R5T.Magyar.Net.Constants;


namespace R5T.D0040
{
    public static class IStringlyTypedUrlOperatorExtensions
    {
        public static string BuildHttpsUrl(this IStringlyTypedUrlOperator stringlyTypedUrlOperator, string host, string path)
        {
            var url = stringlyTypedUrlOperator.BuildUrl(NetConstants.HttpsSchemeValue, host, path);
            return url;
        }

        public static string BuildHttpUnsecureUrl(this IStringlyTypedUrlOperator stringlyTypedUrlOperator, string host, string path)
        {
            var url = stringlyTypedUrlOperator.BuildUrl(NetConstants.HttpSchemeValue, host, path);
            return url;
        }
    }
}
