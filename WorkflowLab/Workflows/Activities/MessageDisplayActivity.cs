using Workflow.Core;
using WorkflowLab.Contexts;
using Common.Core.DependencyInjection;

namespace WorkflowLab.Workflows.Activities
{
    [ServiceLocate(typeof(IMessageDisplayActivity))]
    public class MessageDisplayActivity : SequencialActivity<MessageContext>, IMessageDisplayActivity
    {
        private IActivity<MessageContext> _activity;

        public MessageDisplayActivity(
            IDisplayReferenceActivity displayReferenceActivity, 
            IUpdateMessageActivity updateMessageActivity,
            IDisplayMessageActivity displayMessageActivity) 
            : base(
            displayReferenceActivity, 
            updateMessageActivity, 
            displayMessageActivity)
        {
            _activity = new SequencialActivity<MessageContext>(
                displayReferenceActivity,
                new CheckMessageActivity(CheckMessage, updateMessageActivity),
                displayMessageActivity);
        }

        private bool CheckMessage(MessageContext context)
        {
            return true;
        }

        public override void Execute(MessageContext context)
        {
            _activity.Execute(context);
        }
    }
}
