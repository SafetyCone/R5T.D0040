using System;using R5T.T0064;


namespace R5T.D0040.Default
{[ServiceImplementationMarker]
    public class StringlyTypedUrlOperator : IStringlyTypedUrlOperator,IServiceImplementation
    {
        public string BuildUrl(string scheme, string host, string path)
        {
            var url = $"{scheme}://{host}/{path}";
            return url;
        }
    }
}
