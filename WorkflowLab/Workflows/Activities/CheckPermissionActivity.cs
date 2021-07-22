using System;
using Workflow.Core;
using WorkflowLab.Contexts;

namespace WorkflowLab.Workflows.Activities
{
    public class CheckPermissionActivity : YesNoActivity<MessageContext>, ICheckPermissionActivity
    {
        public CheckPermissionActivity(
            Func<MessageContext, bool> condition, 
            IUpdateMessageActivity updateMessageActivity,
            IDisplayMessageActivity displayMessageActivity) 
            : base(
                  condition, 
                  updateMessageActivity, 
                  displayMessageActivity)
        {
        }
    }
}
