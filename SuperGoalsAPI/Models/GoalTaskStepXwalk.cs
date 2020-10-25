using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class GoalTaskStepXwalk
    {
        public GoalTaskStepXwalk()
        {

        }

        public Guid GoalTaskId { get; set; }
        public Guid GoalTaskStepId { get; set; }
    }
}
