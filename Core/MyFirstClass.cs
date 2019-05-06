public class MyFirstClass
{
    private  string _settings = string.Empty;
    public MyFirstClass(string settings)
    {
        _settings = settings;
    }

    public string PrintSettings()
    {
        return _settings;
    }

}