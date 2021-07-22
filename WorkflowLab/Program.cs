using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WorkflowLab.Workflows;
using WorkflowLab.Workflows.Activities;

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

                        service.AddTransient<IMessageDisplayActivity, MessageDisplayActivity>();
                        service.AddTransient<IDisplayReferenceActivity, DisplayReferenceActivity>();
                        service.AddTransient<IDisplayMessageActivity, DisplayMessageActivity>();
                        service.AddTransient<IMessageDisplayWorkflow, MessageDisplayWorkflow>();
                    }).Build();
        }
    }
}
