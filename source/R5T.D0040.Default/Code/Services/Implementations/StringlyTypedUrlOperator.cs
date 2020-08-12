using System;


namespace R5T.D0040.Default
{
    public class StringlyTypedUrlOperator : IStringlyTypedUrlOperator
    {
        public string BuildUrl(string scheme, string host, string path)
        {
            var url = $"{scheme}://{host}/{path}";
            return url;
        }
    }
}
