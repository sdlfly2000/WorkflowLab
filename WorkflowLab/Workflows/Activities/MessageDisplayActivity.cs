using Workflow.Core;
using WorkflowLab.Contexts;

namespace WorkflowLab.Workflows.Activities
{
    public class MessageDisplayActivity : SequenceActivity<MessageContext>, IMessageDisplayActivity
    {
        public MessageDisplayActivity(
            IDisplayReferenceActivity displayReferenceActivity, 
            IDisplayMessageActivity displayMessageActivity) : base(displayReferenceActivity, displayMessageActivity)
        {
        }
    }
}
