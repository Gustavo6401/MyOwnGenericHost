public class HostBuilder
{
    private readonly ServiceCollection _services = new();

    public HostBuilder ConfigureServices(Action<ServiceCollection> configure)
    {
        configure(_services);
        return this;
    }

    public Host Build()
    {
        var provider = _services.BuildServiceProvider();
        return new Host(provider);
    }
}