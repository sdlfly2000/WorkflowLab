using System;
using WorkflowLab.Contexts;
using Common.Core.DependencyInjection;

namespace WorkflowLab.Workflows.Activities
{
    [ServiceLocate(typeof(IDisplayReferenceActivity))]
    public class DisplayReferenceActivity : IDisplayReferenceActivity
    {
        public void Execute(MessageContext context)
        {
            Console.WriteLine(context.Reference);
        }
    }
}
