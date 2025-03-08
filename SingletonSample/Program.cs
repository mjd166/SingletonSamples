using SingletonSample;

var configurmnger1 = ConfigurationManager.Instance;
configurmnger1.Display();

var configurmnger2= ConfigurationManager.Instance;

Console.WriteLine(ReferenceEquals(configurmnger1, configurmnger2));
Console.ReadKey();