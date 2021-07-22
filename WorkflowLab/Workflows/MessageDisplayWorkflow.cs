using Workflow.Core;
using WorkflowLab.Contexts;
using WorkflowLab.Workflows.Activities;
using Common.Core.DependencyInjection;

namespace WorkflowLab.Workflows
{
    [ServiceLocate(typeof(IMessageDisplayWorkflow))]
    public class MessageDisplayWorkflow : Workflow<MessageContext>, IMessageDisplayWorkflow
    {
        public MessageDisplayWorkflow(
            IMessageDisplayActivity messageDisplayActivity) 
            : base(messageDisplayActivity)
        {
        }
    }
}
