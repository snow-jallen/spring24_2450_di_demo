namespace Demo.Logic;

public class SingletonDemoGreeter : IGreeter
{
    private DateTime bornOn = DateTime.Now;

    public string FormalGreeting(string recipient)
    {
        throw new NotImplementedException();
    }

    public string InformalGreeting()
    {
        return $"This instance was born on {bornOn}";
    }
}
