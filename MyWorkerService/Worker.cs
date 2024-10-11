using MyWorkerService.Contacts;

namespace MyWorkerService;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IMyService _myService;

    public Worker(ILogger<Worker> logger, IMyService myService)
    {
        _logger = logger;
        _myService = myService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                _myService.PrintSecret();
            }
            await Task.Delay(5000, stoppingToken);
        }
    }
}
