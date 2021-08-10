namespace MPesa
{
    public class InternalClient
    {
        private string ApiKey { get; set; }
        private string PublicKey { get; set; }

        private string ServiceProviderCode { get; set; }
        private string InitiatorIdentifier { get; set; }
        private string Host { get; set; }
        private string SecurityCredential { get; set; }

        public InternalClient(string apiKey, string publicKey, string serviceProviderCode, string initiatorIdentifier,
            string host, string securityCredential)
        {
            ApiKey = apiKey;
            PublicKey = publicKey;
            ServiceProviderCode = serviceProviderCode;
            InitiatorIdentifier = initiatorIdentifier;
            Host = host;
            SecurityCredential = securityCredential;
        }
    }
}