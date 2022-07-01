// See https://aka.ms/new-console-template for more information
using DI_Prototype;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");
var builder = new HostBuilder();
builder.ConfigureServices((services) => {
    services.AddDepencencyInjection();
});
var host = builder.Build();
var service = host.Services;

var dataProvider = service.GetService<DataProvider>();
var stringOutput = dataProvider.PrintString("cc");
Console.WriteLine(stringOutput);
Console.ReadLine();