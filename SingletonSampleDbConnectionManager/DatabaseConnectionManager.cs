using System.Data.SqlClient;
namespace SingletonSampleDbConnectionManager
{
    public sealed class DatabaseConnectionManager
    {
        private static DatabaseConnectionManager _instance;
        private static readonly object _lock = new object();
      
        public SqlConnection Connection { get; private set; }


        private DatabaseConnectionManager() {

            //config connection settings.
            var connectionstring = "Server=localhost;Database=MyAppDb;Trusted_Connection=True;";
            Connection=new SqlConnection(connectionstring);
        }


        public static DatabaseConnectionManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if(_instance == null)
                        {
                            _instance = new DatabaseConnectionManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public void OpenConnection()
        {
            if(Connection.State!= System.Data.ConnectionState.Open)
            {
                Connection.Open();
                Console.WriteLine("connection opened.");
            }
        }
        public void CloseConnection()
        {
            if(Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
                Console.WriteLine("Connection closed.");
            }
        }

    }
}
