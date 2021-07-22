using Workflow.Core;
using WorkflowLab.Contexts;

namespace WorkflowLab.Workflows.Activities
{
    public interface ICheckMessageActivity : IConditionActivity<MessageContext>
    {
    }
}
