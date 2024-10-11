using MyWorkerService;
using MyWorkerService.Contacts;
using MyWorkerService.Services;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddHostedService<Worker>();
builder.Services.AddSingleton<IMyService, MyService>();

var host = builder.Build();
host.Run();
