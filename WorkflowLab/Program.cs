using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using Common.Core.DependencyInjection;

namespace WorkflowLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHost().Run();
        }

        private static IHost CreateHost()
        {
            return Host.CreateDefaultBuilder().ConfigureServices(
                (_, service) =>
                    {
                        service.AddHostedService<Start>();

                        DIModule.RegisterDomain(service, new List<string> 
                        {
                            "WorkflowLab"
                        });
                    }).Build();
        }
    }
}
