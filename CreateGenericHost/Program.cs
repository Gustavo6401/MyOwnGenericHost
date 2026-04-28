Host host = new HostBuilder()
    .ConfigureServices(services =>
    {
        services.AddSingleton<IHostedService>(() => new ClockService());
    })
    .Build();

await host.RunAsync();