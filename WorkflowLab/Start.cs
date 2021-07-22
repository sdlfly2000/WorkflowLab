using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using WorkflowLab.Contexts;
using WorkflowLab.Workflows;

namespace WorkflowLab
{
    public class Start : IHostedService
    {
        private readonly IMessageDisplayWorkflow _workflow;

        public Start(IMessageDisplayWorkflow workflow)
        {
            _workflow = workflow;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Start to run...");

            _workflow.Execute(new MessageContext 
            {
                Message = "Message",
                Reference = "Reference"
            });

        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("End to run...");
        }
    }
}
