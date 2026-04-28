public class ServiceCollection
{
    private readonly List<Func<object>> _factories = new();
    
    public void AddSingleton<TService>(Func<TService> factory)
    {
        _factories.Add(() => factory()!);
    }

    public ServiceProvider BuildServiceProvider()
    {
        return new ServiceProvider(_factories);
    }
}