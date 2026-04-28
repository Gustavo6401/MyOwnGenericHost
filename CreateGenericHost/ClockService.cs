public class ClockService : IHostedService
{
    private Timer? _timer;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _timer = new Timer(_ =>
        {
            Console.WriteLine($"Hora: {DateTime.Now}");
        }, null, 0, 1000);

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Dispose();
        Console.WriteLine("ClockService desativado");
        return Task.CompletedTask;
    }
}