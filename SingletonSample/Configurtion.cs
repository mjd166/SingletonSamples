namespace SingletonSample
{
    public class Configurtion
    {
        public string ApiKey { get; set; } 

        public string ApiSecret { get; set; } 

        public string ConStr { get; set; }

        public Configurtion(string apiKey, string apiSecret, string conStr)
        {
            ApiKey = apiKey;
            ApiSecret = apiSecret;
            ConStr = conStr;
        }
    }

}
