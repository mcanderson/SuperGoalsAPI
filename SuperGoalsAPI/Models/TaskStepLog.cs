using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class TaskStepLog
    {
        public TaskStepLog()
        {

        }

        Guid TaskStepLogId { get; set; }
        Guid TaskStepId { get; set; }
        DateTime DateCompleted { get; set; }

    }
}
