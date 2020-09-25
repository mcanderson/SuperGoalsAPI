using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class GoalTask
    {
        public GoalTask()
        {

        }

        Guid TaskId { get; set; }
        string TaskName { get; set; }
        string TaskDescription { get; set; }
        Guid GoalId { get; set; }
        Goal GoalName { get; set; }
        ICollection<TaskLog> TaskLogs { get; set; }
    }
}
