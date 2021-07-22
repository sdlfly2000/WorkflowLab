using System;

namespace Workflow.Core
{
    public class ConditionActivity<TContext> : IConditionActivity<TContext> where TContext : class
    {
        private readonly Func<TContext, bool> _condition;
        private readonly IActivity<TContext> _activity;

        public ConditionActivity(Func<TContext, bool> condition, IActivity<TContext> activity)
        {
            _condition = condition;
            _activity = activity;
        }

        public virtual void Execute(TContext context)
        {
            if (_condition(context))
            {
                _activity.Execute(context);
            }
        }
    }
}
