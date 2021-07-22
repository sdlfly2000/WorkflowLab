using Workflow.Core;
using WorkflowLab.Contexts;
using WorkflowLab.Workflows.Activities;

namespace WorkflowLab.Workflows
{
    public class MessageDisplayWorkflow : Workflow<MessageContext>, IMessageDisplayWorkflow
    {
        public MessageDisplayWorkflow(
            IMessageDisplayActivity messageDisplayActivity) 
            : base(messageDisplayActivity)
        {
        }
    }
}
