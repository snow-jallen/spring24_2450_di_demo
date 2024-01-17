namespace Demo.Logic;

public class WalmartGreeter : IGreeter
{
    public string FormalGreeting(string recipient)
    {
        throw new NotImplementedException();
    }

    public new string InformalGreeting()
    {
        return "Welcome to walmart";
    }
}
