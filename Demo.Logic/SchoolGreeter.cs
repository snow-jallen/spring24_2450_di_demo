using Demo.Persistence;

namespace Demo.Logic;

public class SchoolGreeter : IGreeter
{
    private readonly IDataStore dataStore;

    public SchoolGreeter(IDataStore dataStore)
    {
        this.dataStore = dataStore;
    }

    public string FormalGreeting(string recipient)
    {
        return $"Hello there, {recipient}";
    }

    public string InformalGreeting()
    {
        var greeting= "Hey";
        dataStore.StoreData($"Greeting: {greeting}; Time: {DateTime.Now}");
        return greeting;
    }
}
