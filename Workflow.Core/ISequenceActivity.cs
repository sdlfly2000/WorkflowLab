namespace Workflow.Core
{
    public interface ISequenceActivity<TContext> : IActivity<TContext>
        where TContext : class
    {
    }
}
