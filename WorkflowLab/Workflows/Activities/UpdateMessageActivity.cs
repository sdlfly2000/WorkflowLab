using Common.Core.DependencyInjection;
using WorkflowLab.Contexts;

namespace WorkflowLab.Workflows.Activities
{
    [ServiceLocate(typeof(IUpdateMessageActivity))]
    public class UpdateMessageActivity : IUpdateMessageActivity
    {
        public void Execute(MessageContext context)
        {
            context.Message = "Updated Message";
        }
    }
}
