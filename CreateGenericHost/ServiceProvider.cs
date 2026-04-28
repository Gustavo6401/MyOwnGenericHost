public class ServiceProvider
{
    private readonly List<object> _services;

    public ServiceProvider(List<Func<object>> factories)
    {
        _services = factories.Select(f => f()).ToList();
    }

    public IEnumerable<T> GetServices<T>()
    {
        return _services.OfType<T>();
    }

    public T GetService<T>()
    {
        return _services.OfType<T>().FirstOrDefault()!;
    }
}