namespace Demo.Logic;

public class StoreGreeter : IGreeter
{
    public string FormalGreeting(string recipient)
    {
        return $"Welcome to our store, {recipient}";
    }

    public string InformalGreeting()
    {
        return "Welcome, how can I help you?";
    }
}
