namespace Melody.Server.Configuration
{
    public struct Header
    {
        public string HeaderName { get; set; }
        public string HeaderValue { get; set; }
    }

    public class ApiConfig
    {
        public string Url { get; set; }

        public Header Key { get; set; }

        public Header Host { get; set; }
    }
}
