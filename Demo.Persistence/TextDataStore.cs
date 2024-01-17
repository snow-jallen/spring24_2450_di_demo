namespace Demo.Persistence;

public interface IDataStore
{
    void StoreData(string data);
}
public class TextDataStore : IDataStore
{
    private string fileName = "data.txt";
    public void StoreData(string data)
    {
        File.AppendAllText(fileName, data + "\n");
    }
}

public class ConsoleDataStore : IDataStore
{
    public void StoreData(string data)
    {
        Console.WriteLine(data);
    }
}

public class TestDataStore : IDataStore
{
    List<string> list = new List<string>(); 
    void IDataStore.StoreData(string data)
    {
        list.Add(data);
    }
}
