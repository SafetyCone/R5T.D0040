using System;


namespace R5T.D0040
{
    public interface IStringlyTypedUrlOperator
    {
        /// <summary>
        /// Builds a URL.
        /// </summary>
        /// <param name="unprefixedPath">A path without a prefixed path separator. Ex: SafetyCone/R5T.E0005.Private.git</param>
        string BuildUrl(string scheme, string host, string unprefixedPath);
    }
}
