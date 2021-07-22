namespace Workflow.Core
{
    public interface IConditionActivity<TContext> : IActivity<TContext> 
        where TContext : class
    {
    }
}
