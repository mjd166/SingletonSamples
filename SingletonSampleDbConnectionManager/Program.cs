using SingletonSampleDbConnectionManager;

var dbconnectionmanager1= DatabaseConnectionManager.Instance;
//dbconnectionmanager1.OpenConnection();
var dbconnectionmanager2= DatabaseConnectionManager.Instance;

Console.WriteLine(ReferenceEquals(dbconnectionmanager1, dbconnectionmanager2));
