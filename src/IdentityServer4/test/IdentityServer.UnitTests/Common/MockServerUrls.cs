namespace IdentityServer.UnitTests.Common
{
    public class MockServerUrls
    {
        public string Origin { get; set; }
        public string BasePath { get; set; }

        /// <summary>
        /// Gets the base URL for IdentityServer.
        /// </summary>
        public string BaseUrl { get => Origin + BasePath; }
    }
}