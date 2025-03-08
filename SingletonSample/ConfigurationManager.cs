namespace SingletonSample
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private static readonly object _lock = new object();


        public Configurtion Config { get; set; }


        private ConfigurationManager()
        {
            //simulate the load config from every where .

            Config = new Configurtion("Test ApiKey", "Test secreet key", "server=.;");
        }

        public static ConfigurationManager Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock(_lock)
                    {
                        if(_instance == null)
                        {
                            _instance = new ConfigurationManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Display()
        {
            Console.WriteLine(Config.ConStr);
            //can do anything.
        }

    }

}
