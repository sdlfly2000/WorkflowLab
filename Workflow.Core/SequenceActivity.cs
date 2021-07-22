﻿using System.Collections.Generic;
using System.Linq;

namespace Workflow.Core
{
    public class SequenceActivity<TContext> : ISequenceActivity<TContext> where TContext : class
    {
        private IEnumerable<IActivity<TContext>> _activities;

        public SequenceActivity(params IActivity<TContext>[] activities)
        {
            _activities = activities.AsEnumerable();
        }

        public virtual void Execute(TContext context)
        {
            foreach (var activity in _activities)
            {
                activity.Execute(context);
            }
        }
    }
}
