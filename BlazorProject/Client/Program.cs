using BlazorProject.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDczMzU0QDMxMzkyZTMyMmUzME1LVmtFd0l3U1RLYkxLSUZxeEEybUZvb1FhNlF2Nm5HaGpYQVFlSzJYbUk9;NDczMzU1QDMxMzkyZTMyMmUzMEUxSktuRU5ueE5JN2Yyb1ZtN2VQV0JyZUQxRTJjNFFaeHBIVndCdnd5L009;NDczMzU2QDMxMzkyZTMyMmUzMFRyOHM5RkhZaUhuWUtzRFhsOWY1Tlp2eHJzUnZxU1ErV3ljUnBzSGcrVHM9;NDczMzU3QDMxMzkyZTMyMmUzME10OHhDMDl1RXBJcGRFS0xVL1lhWFBoaHFDa0lTUUlDc0luWFd4UWdtVHM9;NDczMzU4QDMxMzkyZTMyMmUzMEJ4ZFRHeFp3MFREVVdiaDNnQU9JK1o2UC82RWNSRXJZTmkyaWZRdTlneVE9;NDczMzU5QDMxMzkyZTMyMmUzMGprZzVMWXVmb1E1S3M3dmJvWm9WKzJDZUJNbGUyMXlIdTIwSTBKSE5aUFE9;NDczMzYwQDMxMzkyZTMyMmUzMGVWSWI5YXo0cVNwdGNSVFVSVFRmOC81Rm1XNEN4eUh1TXAzWCtFSkp2Yjg9;NDczMzYxQDMxMzkyZTMyMmUzMEdlNGdZTk0ycnJNRjdubmhxTUFjSWs3NC9MODdLVmZpS25ta3JYWlJQNlk9;NDczMzYyQDMxMzkyZTMyMmUzMEZKRStxa0dCMFNzMnNvUlJoVjFuMG9OVVV2MzFhS2RvZ0djSWttNjZSOUU9;NDczMzYzQDMxMzkyZTMyMmUzMEk4UHE0QTJWUUthbkJ5QWJkd09LYTFybU9qUnFDUnF3VnFwL3FGRGJhbmc9");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient<IEmployeeService, EmployeeService>(client =>
            {
                client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
            });

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();
        }
    }
}
