public class Host
{
    private readonly ServiceProvider _provider;
    private List<IHostedService> _hostedServices;

    public Host(ServiceProvider provider)
    {
        _provider = provider;
        _hostedServices = _provider.GetServices<IHostedService>().ToList();
    }

    public async Task RunAsync()
    {
        Console.WriteLine("Host Iniciado");

        CancellationTokenSource cts = new CancellationTokenSource();

        // CTRL + C
        Console.CancelKeyPress += (s, e) =>
        {
            Console.WriteLine("Encerrando");
            cts.Cancel();
            e.Cancel = true;
        };

        // START
        foreach (var service in _hostedServices)
        {
            await service.StartAsync(cts.Token);
        }

        // LOOP
        try 
        {
            await Task.Delay(Timeout.Infinite, cts.Token);
        }
        catch (TaskCanceledException)
        {

        }

        foreach (var service in _hostedServices)
        {
            await service.StopAsync(CancellationToken.None);            
        }

        Console.WriteLine("Host Finalizado.");
    }
}